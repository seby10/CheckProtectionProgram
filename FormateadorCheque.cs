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
            // Formato con separador de miles y dos decimales
            string cantidadFormateada = cantidad.ToString("N2");

            // Calcular cuántos asteriscos necesitamos
            int asteriscosNecesarios = espaciosDisponibles - cantidadFormateada.Length;

            // Si no necesitamos asteriscos, solo devolvemos la cantidad formateada
            if (asteriscosNecesarios <= 0)
                return cantidadFormateada;

            // Agregar asteriscos a la izquierda
            return new string('*', asteriscosNecesarios) + cantidadFormateada;
        }
    }
}
