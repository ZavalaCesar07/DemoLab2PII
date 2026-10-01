using System;
using System.Collections.Generic;
using System.Text;

namespace Empleado.Entity
{
    public class EmpleadoPorHora : Empleado
    {
        public int CantidadHoras { get; set; }
        public decimal PrecioHora { get; set; }

        public EmpleadoPorHora()
        {
        }

        public EmpleadoPorHora(int empleadoId, string nombre, string apellido, decimal salarioBase, int cantidadHoras, decimal precioHora)
            : base(empleadoId, nombre, apellido, salarioBase)
        {
            CantidadHoras = cantidadHoras;
            PrecioHora = precioHora;
        }

        public override decimal CalcularSalario()
        {
            return CantidadHoras * PrecioHora;
        }
    }
}
