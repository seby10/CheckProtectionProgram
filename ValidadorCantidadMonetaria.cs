using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckProtectionProgra_
{
    // Clase para validar cantidades monetarias (Principio de Responsabilidad Única)
    public class ValidadorCantidadMonetaria : IValidador
    {
        public string MensajeError { get; private set; }

        public bool EsValido(decimal cantidad, int espaciosDisponibles)
        {
            if (cantidad <= 0)
            {
                MensajeError = "La cantidad debe ser mayor a cero.";
                return false;
            }

            // Convertir la cantidad al formato con separador de miles para validar longitud
            string cantidadFormateada = cantidad.ToString("N2");

            if (cantidadFormateada.Length > espaciosDisponibles)
            {
                MensajeError = $"La cantidad {cantidadFormateada} excede el límite de {espaciosDisponibles} caracteres.";
                return false;
            }

            return true;
        }
    }
}
