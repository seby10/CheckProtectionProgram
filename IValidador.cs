using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckProtectionProgra_
{
    // Interfaz para validar entradas (Principio de Segregación de Interfaces)
    public interface IValidador
    {
        bool EsValido(decimal cantidad, int espaciosDisponibles);
        string MensajeError { get; }
    }
}
