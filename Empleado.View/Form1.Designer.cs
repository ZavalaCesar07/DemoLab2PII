namespace Empleado.View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button1CALCULAR = new Button();
            DTAGRIDVIECALCULODESALARIOS = new DataGridView();
            dataGridView1DETALLESDEEMPLEADOS = new DataGridView();
            groupBox2 = new GroupBox();
            radioButton1PORHORA = new RadioButton();
            radioButton1TIEMPOCOMPLETO = new RadioButton();
            groupBox1 = new GroupBox();
            textBox7ANTIDADHORAS = new TextBox();
            textBox6PRECIOPORHORA = new TextBox();
            label2 = new Label();
            label7 = new Label();
            groupEmpleaodatos1 = new GroupBox();
            textBox5SALARIOBASE = new TextBox();
            textBox4DUI = new TextBox();
            textBox3APELLIDO = new TextBox();
            textBox2NOMBRE = new TextBox();
            textBox1EMPLEADOID = new TextBox();
            label6SalarioBase = new Label();
            label5EmpleadoId = new Label();
            label4apellido = new Label();
            DUIlb = new Label();
            label2name = new Label();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTAGRIDVIECALCULODESALARIOS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1DETALLESDEEMPLEADOS).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupEmpleaodatos1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 749);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1CALCULAR);
            panel2.Controls.Add(DTAGRIDVIECALCULODESALARIOS);
            panel2.Controls.Add(dataGridView1DETALLESDEEMPLEADOS);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupEmpleaodatos1);
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 609);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT", 14.25F);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(368, 311);
            label4.Name = "label4";
            label4.Size = new Size(191, 27);
            label4.TabIndex = 11;
            label4.Text = "RESUMEN DE PAGOS";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans MT", 14.25F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(368, 16);
            label3.Name = "label3";
            label3.Size = new Size(224, 27);
            label3.TabIndex = 10;
            label3.Text = "PERSONAL REGISTRADO";
            label3.Click += label3_Click;
            // 
            // button1CALCULAR
            // 
            button1CALCULAR.BackColor = Color.DarkGoldenrod;
            button1CALCULAR.FlatStyle = FlatStyle.Flat;
            button1CALCULAR.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1CALCULAR.ForeColor = Color.White;
            button1CALCULAR.Location = new Point(79, 550);
            button1CALCULAR.Name = "button1CALCULAR";
            button1CALCULAR.Size = new Size(207, 46);
            button1CALCULAR.TabIndex = 10;
            button1CALCULAR.Text = "CALCULAR SALARIO";
            button1CALCULAR.UseVisualStyleBackColor = false;
            button1CALCULAR.Click += button1CALCULAR_Click;
            // 
            // DTAGRIDVIECALCULODESALARIOS
            // 
            DTAGRIDVIECALCULODESALARIOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTAGRIDVIECALCULODESALARIOS.Location = new Point(368, 341);
            DTAGRIDVIECALCULODESALARIOS.Name = "DTAGRIDVIECALCULODESALARIOS";
            DTAGRIDVIECALCULODESALARIOS.Size = new Size(567, 212);
            DTAGRIDVIECALCULODESALARIOS.TabIndex = 9;
            DTAGRIDVIECALCULODESALARIOS.CellContentClick += DTAGRIDVIECALCULODESALARIOS_CellContentClick;
            // 
            // dataGridView1DETALLESDEEMPLEADOS
            // 
            dataGridView1DETALLESDEEMPLEADOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1DETALLESDEEMPLEADOS.Location = new Point(368, 48);
            dataGridView1DETALLESDEEMPLEADOS.Name = "dataGridView1DETALLESDEEMPLEADOS";
            dataGridView1DETALLESDEEMPLEADOS.Size = new Size(567, 245);
            dataGridView1DETALLESDEEMPLEADOS.TabIndex = 8;
            dataGridView1DETALLESDEEMPLEADOS.CellContentClick += dataGridView1DETALLESDEEMPLEADOS_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton1PORHORA);
            groupBox2.Controls.Add(radioButton1TIEMPOCOMPLETO);
            groupBox2.Font = new Font("Gill Sans MT", 12F);
            groupBox2.ForeColor = Color.Maroon;
            groupBox2.Location = new Point(12, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 90);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "TIPO DE EMPLEADO";
            // 
            // radioButton1PORHORA
            // 
            radioButton1PORHORA.AutoSize = true;
            radioButton1PORHORA.Font = new Font("Microsoft Sans Serif", 9.75F);
            radioButton1PORHORA.ForeColor = Color.Black;
            radioButton1PORHORA.Location = new Point(6, 51);
            radioButton1PORHORA.Name = "radioButton1PORHORA";
            radioButton1PORHORA.Size = new Size(76, 20);
            radioButton1PORHORA.TabIndex = 1;
            radioButton1PORHORA.TabStop = true;
            radioButton1PORHORA.Text = "Por hora";
            radioButton1PORHORA.UseVisualStyleBackColor = true;
            radioButton1PORHORA.CheckedChanged += radioButton1PORHORA_CheckedChanged;
            // 
            // radioButton1TIEMPOCOMPLETO
            // 
            radioButton1TIEMPOCOMPLETO.AutoSize = true;
            radioButton1TIEMPOCOMPLETO.Font = new Font("Microsoft Sans Serif", 9.75F);
            radioButton1TIEMPOCOMPLETO.ForeColor = Color.Black;
            radioButton1TIEMPOCOMPLETO.Location = new Point(6, 25);
            radioButton1TIEMPOCOMPLETO.Name = "radioButton1TIEMPOCOMPLETO";
            radioButton1TIEMPOCOMPLETO.Size = new Size(131, 20);
            radioButton1TIEMPOCOMPLETO.TabIndex = 0;
            radioButton1TIEMPOCOMPLETO.TabStop = true;
            radioButton1TIEMPOCOMPLETO.Text = "Tiempo completo";
            radioButton1TIEMPOCOMPLETO.UseVisualStyleBackColor = true;
            radioButton1TIEMPOCOMPLETO.CheckedChanged += radioButton1TIEMPOCOMPLETO_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7ANTIDADHORAS);
            groupBox1.Controls.Add(textBox6PRECIOPORHORA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Gill Sans MT", 12F);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(12, 429);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 113);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DE EMPLEADO POR HORA";
            // 
            // textBox7ANTIDADHORAS
            // 
            textBox7ANTIDADHORAS.Location = new Point(147, 40);
            textBox7ANTIDADHORAS.Name = "textBox7ANTIDADHORAS";
            textBox7ANTIDADHORAS.Size = new Size(178, 26);
            textBox7ANTIDADHORAS.TabIndex = 11;
            textBox7ANTIDADHORAS.TextChanged += textBox7ANTIDADHORAS_TextChanged;
            // 
            // textBox6PRECIOPORHORA
            // 
            textBox6PRECIOPORHORA.Location = new Point(147, 72);
            textBox6PRECIOPORHORA.Name = "textBox6PRECIOPORHORA";
            textBox6PRECIOPORHORA.Size = new Size(178, 26);
            textBox6PRECIOPORHORA.TabIndex = 10;
            textBox6PRECIOPORHORA.TextChanged += textBox6PRECIOPORHORA_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 7;
            label2.Text = "Precio por hora:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(5, 40);
            label7.Name = "label7";
            label7.Size = new Size(120, 16);
            label7.TabIndex = 5;
            label7.Text = "Cantidad de horas:";
            // 
            // groupEmpleaodatos1
            // 
            groupEmpleaodatos1.Controls.Add(textBox5SALARIOBASE);
            groupEmpleaodatos1.Controls.Add(textBox4DUI);
            groupEmpleaodatos1.Controls.Add(textBox3APELLIDO);
            groupEmpleaodatos1.Controls.Add(textBox2NOMBRE);
            groupEmpleaodatos1.Controls.Add(textBox1EMPLEADOID);
            groupEmpleaodatos1.Controls.Add(label6SalarioBase);
            groupEmpleaodatos1.Controls.Add(label5EmpleadoId);
            groupEmpleaodatos1.Controls.Add(label4apellido);
            groupEmpleaodatos1.Controls.Add(DUIlb);
            groupEmpleaodatos1.Controls.Add(label2name);
            groupEmpleaodatos1.Font = new Font("Gill Sans MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupEmpleaodatos1.ForeColor = Color.Maroon;
            groupEmpleaodatos1.Location = new Point(12, 148);
            groupEmpleaodatos1.Name = "groupEmpleaodatos1";
            groupEmpleaodatos1.Size = new Size(331, 277);
            groupEmpleaodatos1.TabIndex = 0;
            groupEmpleaodatos1.TabStop = false;
            groupEmpleaodatos1.Text = "DATOS DEL EMPLEADO";
            // 
            // textBox5SALARIOBASE
            // 
            textBox5SALARIOBASE.Location = new Point(105, 191);
            textBox5SALARIOBASE.Name = "textBox5SALARIOBASE";
            textBox5SALARIOBASE.Size = new Size(178, 30);
            textBox5SALARIOBASE.TabIndex = 9;
            textBox5SALARIOBASE.TextChanged += textBox5SALARIOBASE_TextChanged;
            // 
            // textBox4DUI
            // 
            textBox4DUI.Location = new Point(105, 152);
            textBox4DUI.Name = "textBox4DUI";
            textBox4DUI.Size = new Size(178, 30);
            textBox4DUI.TabIndex = 8;
            textBox4DUI.TextChanged += textBox4DUI_TextChanged;
            // 
            // textBox3APELLIDO
            // 
            textBox3APELLIDO.Location = new Point(105, 113);
            textBox3APELLIDO.Name = "textBox3APELLIDO";
            textBox3APELLIDO.Size = new Size(178, 30);
            textBox3APELLIDO.TabIndex = 7;
            textBox3APELLIDO.TextChanged += textBox3APELLIDO_TextChanged;
            // 
            // textBox2NOMBRE
            // 
            textBox2NOMBRE.Location = new Point(105, 71);
            textBox2NOMBRE.Name = "textBox2NOMBRE";
            textBox2NOMBRE.Size = new Size(178, 30);
            textBox2NOMBRE.TabIndex = 6;
            textBox2NOMBRE.TextChanged += textBox2NOMBRE_TextChanged;
            // 
            // textBox1EMPLEADOID
            // 
            textBox1EMPLEADOID.Location = new Point(105, 32);
            textBox1EMPLEADOID.Name = "textBox1EMPLEADOID";
            textBox1EMPLEADOID.Size = new Size(178, 30);
            textBox1EMPLEADOID.TabIndex = 5;
            textBox1EMPLEADOID.TextChanged += textBox1EMPLEADOID_TextChanged;
            // 
            // label6SalarioBase
            // 
            label6SalarioBase.AutoSize = true;
            label6SalarioBase.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6SalarioBase.ForeColor = Color.Black;
            label6SalarioBase.Location = new Point(5, 191);
            label6SalarioBase.Name = "label6SalarioBase";
            label6SalarioBase.Size = new Size(88, 16);
            label6SalarioBase.TabIndex = 4;
            label6SalarioBase.Text = "Salario Base:";
            // 
            // label5EmpleadoId
            // 
            label5EmpleadoId.AutoSize = true;
            label5EmpleadoId.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5EmpleadoId.ForeColor = Color.Black;
            label5EmpleadoId.Location = new Point(5, 32);
            label5EmpleadoId.Name = "label5EmpleadoId";
            label5EmpleadoId.Size = new Size(84, 16);
            label5EmpleadoId.TabIndex = 3;
            label5EmpleadoId.Text = "EmpleadoId:";
            label5EmpleadoId.Click += label5_Click;
            // 
            // label4apellido
            // 
            label4apellido.AutoSize = true;
            label4apellido.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4apellido.ForeColor = Color.Black;
            label4apellido.Location = new Point(6, 113);
            label4apellido.Name = "label4apellido";
            label4apellido.Size = new Size(60, 16);
            label4apellido.TabIndex = 2;
            label4apellido.Text = "Apellido:";
            label4apellido.Click += label4_Click;
            // 
            // DUIlb
            // 
            DUIlb.AutoSize = true;
            DUIlb.Font = new Font("Microsoft Sans Serif", 9.75F);
            DUIlb.ForeColor = Color.Black;
            DUIlb.Location = new Point(6, 152);
            DUIlb.Name = "DUIlb";
            DUIlb.Size = new Size(33, 16);
            DUIlb.TabIndex = 1;
            DUIlb.Text = "DUI:";
            // 
            // label2name
            // 
            label2name.AutoSize = true;
            label2name.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2name.ForeColor = Color.Black;
            label2name.Location = new Point(5, 71);
            label2name.Name = "label2name";
            label2name.Size = new Size(59, 16);
            label2name.TabIndex = 0;
            label2name.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(371, 30);
            label1.Name = "label1";
            label1.Size = new Size(214, 33);
            label1.TabIndex = 0;
            label1.Text = "NOMINACORE";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(147, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 20);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pasante";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 9.75F);
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(147, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(168, 20);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Empleado por comision";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 749);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTAGRIDVIECALCULODESALARIOS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1DETALLESDEEMPLEADOS).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupEmpleaodatos1.ResumeLayout(false);
            groupEmpleaodatos1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupEmpleaodatos1;
        private Label label7;
        private Label label6SalarioBase;
        private Label label5EmpleadoId;
        private Label label4apellido;
        private Label DUIlb;
        private Label label2name;
        private GroupBox groupBox1;
        private TextBox textBox5SALARIOBASE;
        private TextBox textBox4DUI;
        private TextBox textBox3APELLIDO;
        private TextBox textBox2NOMBRE;
        private TextBox textBox1EMPLEADOID;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton radioButton1PORHORA;
        private RadioButton radioButton1TIEMPOCOMPLETO;
        private TextBox textBox7ANTIDADHORAS;
        private TextBox textBox6PRECIOPORHORA;
        private DataGridView DTAGRIDVIECALCULODESALARIOS;
        private DataGridView dataGridView1DETALLESDEEMPLEADOS;
        private Button button1CALCULAR;
        private Label label3;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
