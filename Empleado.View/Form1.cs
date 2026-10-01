using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Empleado.Entity;

namespace Empleado.View
{
    public partial class Form1 : Form
    {
        private List<Empleado.Entity.Empleado> listaEmpleados = new List<Empleado.Entity.Empleado>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarTablas();
            ActualizarEstadoCampos();
        }

        private void ConfigurarTablas()
        {
            dataGridView1DETALLESDEEMPLEADOS.Columns.Clear();
            dataGridView1DETALLESDEEMPLEADOS.Columns.Add("colId", "ID");
            dataGridView1DETALLESDEEMPLEADOS.Columns.Add("colNombre", "Nombre");
            dataGridView1DETALLESDEEMPLEADOS.Columns.Add("colApellido", "Apellido");
            dataGridView1DETALLESDEEMPLEADOS.Columns.Add("colDui", "DUI");
            dataGridView1DETALLESDEEMPLEADOS.Columns.Add("colTipo", "Tipo");

            DTAGRIDVIECALCULODESALARIOS.Columns.Clear();
            DTAGRIDVIECALCULODESALARIOS.Columns.Add("colNombre", "Empleado");
            DTAGRIDVIECALCULODESALARIOS.Columns.Add("colBase", "Salario Base");
            DTAGRIDVIECALCULODESALARIOS.Columns.Add("colAFP", "AFP");
            DTAGRIDVIECALCULODESALARIOS.Columns.Add("colISSS", "ISSS");
            DTAGRIDVIECALCULODESALARIOS.Columns.Add("colDescuentos", "Total Descuentos");
            DTAGRIDVIECALCULODESALARIOS.Columns.Add("colSalarioNeto", "Salario Final");

            DTAGRIDVIECALCULODESALARIOS.Columns["colBase"].DefaultCellStyle.Format = "$#,##0.00";
            DTAGRIDVIECALCULODESALARIOS.Columns["colAFP"].DefaultCellStyle.Format = "$#,##0.00";
            DTAGRIDVIECALCULODESALARIOS.Columns["colISSS"].DefaultCellStyle.Format = "$#,##0.00";
            DTAGRIDVIECALCULODESALARIOS.Columns["colDescuentos"].DefaultCellStyle.Format = "$#,##0.00";
            DTAGRIDVIECALCULODESALARIOS.Columns["colSalarioNeto"].DefaultCellStyle.Format = "$#,##0.00";
        }

        private void ActualizarEstadoCampos()
        {
            bool esPorHora = radioButton1PORHORA.Checked;

            textBox7ANTIDADHORAS.Enabled = esPorHora;
            textBox6PRECIOPORHORA.Enabled = esPorHora;

            textBox5SALARIOBASE.Enabled = !esPorHora;
        }

        private void radioButton1TIEMPOCOMPLETO_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarEstadoCampos();
        }

        private void radioButton1PORHORA_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarEstadoCampos();
        }

        private void button1CALCULAR_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1EMPLEADOID.Text);
                string nombre = textBox2NOMBRE.Text;
                string apellido = textBox3APELLIDO.Text;
                string dui = textBox4DUI.Text;

                Empleado.Entity.Empleado nuevoEmpleado = null;

                if (radioButton1PORHORA.Checked)
                {
                    int horas = int.Parse(textBox7ANTIDADHORAS.Text);
                    decimal precioHora = decimal.Parse(textBox6PRECIOPORHORA.Text);

                    nuevoEmpleado = new EmpleadoPorHora(id, nombre, apellido, 0, horas, precioHora)
                    {
                        DUI = dui
                    };
                }
                else if (radioButton1TIEMPOCOMPLETO.Checked)
                {
                    decimal salarioBase = decimal.Parse(textBox5SALARIOBASE.Text);

                    nuevoEmpleado = new EmpleadoTiempoCompleto(id, nombre, apellido, salarioBase)
                    {
                        DUI = dui
                    };
                }

                if (nuevoEmpleado != null)
                {
                    listaEmpleados.Add(nuevoEmpleado);
                    ActualizarGrillas();
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, verifica los datos ingresados: " + ex.Message, "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrillas()
        {
            dataGridView1DETALLESDEEMPLEADOS.Rows.Clear();
            DTAGRIDVIECALCULODESALARIOS.Rows.Clear();

            foreach (var emp in listaEmpleados)
            {
                decimal salarioNeto = emp.CalcularSalario();
                string tipo = "";
                decimal afp = 0;
                decimal isss = 0;
                decimal descuentos = 0;

                if (emp is EmpleadoPorHora)
                {
                    tipo = "Por Hora";
                }
                else if (emp is EmpleadoTiempoCompleto tc)
                {
                    tipo = "Tiempo Completo";
                    afp = tc.TotalAFP;
                    isss = tc.TotalISSS;
                    descuentos = tc.TotalDescuentos;
                }

                dataGridView1DETALLESDEEMPLEADOS.Rows.Add(emp.EmpleadoId, emp.Nombre, emp.Apellido, emp.DUI, tipo);

                DTAGRIDVIECALCULODESALARIOS.Rows.Add($"{emp.Nombre} {emp.Apellido}", emp.SalarioBase, afp, isss, descuentos, salarioNeto);
            }
        }

        private void LimpiarFormulario()
        {
            textBox1EMPLEADOID.Clear();
            textBox2NOMBRE.Clear();
            textBox3APELLIDO.Clear();
            textBox4DUI.Clear();
            textBox5SALARIOBASE.Clear();
            textBox6PRECIOPORHORA.Clear();
            textBox7ANTIDADHORAS.Clear();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox1EMPLEADOID_TextChanged(object sender, EventArgs e) { }
        private void textBox2NOMBRE_TextChanged(object sender, EventArgs e) { }
        private void textBox3APELLIDO_TextChanged(object sender, EventArgs e) { }
        private void textBox4DUI_TextChanged(object sender, EventArgs e) { }
        private void textBox5SALARIOBASE_TextChanged(object sender, EventArgs e) { }
        private void textBox6PRECIOPORHORA_TextChanged(object sender, EventArgs e) { }
        private void textBox7ANTIDADHORAS_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1DETALLESDEEMPLEADOS_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void DTAGRIDVIECALCULODESALARIOS_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}