using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckProtectionProgra_
{

    // Clase de servicio que gestiona la protección de cheques (Principio de Inversión de Dependencias)
    public class ServicioProteccionCheques
    {
        private readonly IFormateador _formateador;
        private readonly IValidador _validador;

        public ServicioProteccionCheques(IFormateador formateador, IValidador validador)
        {
            _formateador = formateador ?? throw new ArgumentNullException(nameof(formateador));
            _validador = validador ?? throw new ArgumentNullException(nameof(validador));
        }

        public string ProtegerCheque(decimal cantidad, int espaciosDisponibles)
        {
            if (!_validador.EsValido(cantidad, espaciosDisponibles))
            {
                throw new ArgumentException(_validador.MensajeError);
            }

            return _formateador.Formatear(cantidad, espaciosDisponibles);
        }
    }
}
