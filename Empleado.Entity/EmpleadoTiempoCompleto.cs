using System;
using System.Collections.Generic;
using System.Text;

namespace Empleado.Entity
{
    public class EmpleadoTiempoCompleto : Empleado
    {
        public decimal TotalDescuentos { get; set; }
        public decimal TotalAFP { get; set; }
        public decimal TotalISSS { get; set; }

        public EmpleadoTiempoCompleto()
        {
        }

        public EmpleadoTiempoCompleto(int empleadoId, string nombre, string apellido, decimal salarioBase)
            : base(empleadoId, nombre, apellido, salarioBase)
        {
        }

        public override decimal CalcularSalario()
        {
            TotalAFP = SalarioBase * 0.0725m;
            TotalISSS = SalarioBase * 0.03m;
            TotalDescuentos = TotalAFP + TotalISSS;

            return SalarioBase - TotalDescuentos;
        }
    }
}
