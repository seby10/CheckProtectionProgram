using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckProtectionProgra_
{
    // Clase concreta para formatear cheques con asteriscos (Principio de Responsabilidad Única)
    public class FormateadorCheque : IFormateador
    {
        public string Formatear(decimal cantidad, int espaciosDisponibles)
        {
            string cantidadFormateada = cantidad.ToString("N2");

            int asteriscosNecesarios = espaciosDisponibles - cantidadFormateada.Length;

            if (asteriscosNecesarios <= 0)
                return cantidadFormateada;

            return new string('*', asteriscosNecesarios) + cantidadFormateada;
        }
    }
}
