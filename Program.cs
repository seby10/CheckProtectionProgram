using CheckProtectionProgra_;

namespace CheckProtectionProgram;

internal class Program
{
    static void Main(string[] args)
    {
        const int ESPACIOS_DISPONIBLES = 8;

        IFormateador formateador = new FormateadorCheque();
        IValidador validador = new ValidadorCantidadMonetaria();
        IUserInterface ui = new ConsoleUserInterface();

        ServicioProteccionCheques servicio = new(formateador, validador);

        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Sistema de Protección de Cheques");
            Console.WriteLine("===============================\n");
            Console.WriteLine("1. Ingresar importe del cheque");
            Console.WriteLine("2. Salir");
            Console.Write("\nSeleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion) || (opcion != 1 && opcion != 2))
            {
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                Console.ReadLine();
                continue;
            }

            if (opcion == 1)
            {
                try
                {
                    decimal cantidad = ui.SolicitarCantidad();
                    string resultadoProtegido = servicio.ProtegerCheque(cantidad, ESPACIOS_DISPONIBLES);
                    ui.MostrarResultado(resultadoProtegido);
                }
                catch (Exception ex)
                {
                    ui.MostrarError(ex.Message);
                }

                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();
            }

        } while (opcion != 2);

        Console.WriteLine("Gracias por usar el sistema. ¡Adiós!");
    }


}