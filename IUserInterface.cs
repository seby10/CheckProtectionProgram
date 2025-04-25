using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckProtectionProgra_
{
    // Interfaz para gestionar la entrada/salida (Principio de Segregación de Interfaces)
    public interface IUserInterface
    {
        decimal SolicitarCantidad();
        void MostrarResultado(string resultado);
        void MostrarError(string mensaje);
    }
}
