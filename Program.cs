using CheckProtectionProgra_;

namespace CheckProtectionProgram;

internal class Program
{
    static void Main(string[] args)
    {
        const int ESPACIOS_DISPONIBLES = 8;

        // Crear componentes concretos
        IFormateador formateador = new FormateadorCheque();
        IValidador validador = new ValidadorCantidadMonetaria();
        IUserInterface ui = new ConsoleUserInterface();

        // Crear servicio mediante inyección de dependencias
        ServicioProteccionCheques servicio = new ServicioProteccionCheques(formateador, validador);

        try
        {
            Console.WriteLine("Sistema de Protección de Cheques");
            Console.WriteLine("===============================\n");

            // Solicitar cantidad al usuario
            decimal cantidad = ui.SolicitarCantidad();

            // Procesar y mostrar resultado
            string resultadoProtegido = servicio.ProtegerCheque(cantidad, ESPACIOS_DISPONIBLES);
            ui.MostrarResultado(resultadoProtegido);
        }
        catch (Exception ex)
        {
            ui.MostrarError(ex.Message);
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
    
}