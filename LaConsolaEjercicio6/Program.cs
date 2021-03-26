using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsolaEjercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;

            do
            {
                Console.WriteLine("Ingrese CTRL + SHIFT + F para salir");
                tecla = Console.ReadKey();

                if ((tecla.Modifiers & ConsoleModifiers.Control) != 0 
                        && (tecla.Modifiers & ConsoleModifiers.Shift) != 0
                            && tecla.Key == ConsoleKey.F
                                && (tecla.Modifiers & ConsoleModifiers.Alt) == 0)
                {
                    break;
                }

            } while (true);

        }
    }
}
