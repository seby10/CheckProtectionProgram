using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckProtectionProgra_
{
    // Interfaz para definir comportamiento de formato (Principio de Segregación de Interfaces)
    public interface IFormateador
    {
        string Formatear(decimal cantidad, int espaciosDisponibles);
    }
}
