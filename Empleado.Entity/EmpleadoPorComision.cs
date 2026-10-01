using System;
using System.Collections.Generic;
using System.Text;

namespace Empleado.Entity
{
    public class EmpleadoPorComision : Empleado
    {
        public decimal TotalVenta { get; set; }
        public decimal PorcentajeDeComision { get; set; }

        public EmpleadoPorComision()
        {

        }

        public EmpleadoPorComision(int empleadoId, string nombre, string apellido, decimal salarioBase, decimal totalVenta, decimal porcentajeDeComision)
            : base(empleadoId, nombre, apellido, salarioBase)
        {
            TotalVenta = totalVenta;
            PorcentajeDeComision = porcentajeDeComision;

        }

        public override decimal CalcularSalario()
        {
            return TotalVenta * PorcentajeDeComision;
        }
    }
}
