using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CheckProtectionProgram.Program;

namespace CheckProtectionProgra_
{
    // Implementación de consola para la interfaz de usuario (Principio de Responsabilidad Única)
    public class ConsoleUserInterface : IUserInterface
    {
        public decimal SolicitarCantidad()
        {
            Console.Write("Ingrese el importe monetario del cheque: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal cantidad))
            {
                return cantidad;
            }

            throw new FormatException("El formato de la cantidad ingresada no es válido.");
        }

        public void MostrarResultado(string resultado)
        {
            Console.WriteLine("\nCheque protegido:");
            Console.WriteLine(resultado);
            Console.WriteLine("12345678 (posiciones números)");
        }

        public void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {mensaje}");
            Console.ResetColor();
        }
    }
}
