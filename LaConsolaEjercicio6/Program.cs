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
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;
            bool salidaControl = false;
            bool salidaShift = false;
            bool salidaF = false;

            do
            {
                Console.WriteLine("Presiona cualquier tecla. Para salir presiona CTRL + F");
                tecla = Console.ReadKey();
                Console.Write(" --- Presionaste las teclas: ");
                if (tecla.Modifiers == ConsoleModifiers.Alt) Console.Write("ALT + ");
                if (tecla.Modifiers == ConsoleModifiers.Shift) Console.Write("SHIFT + ");
                if (tecla.Modifiers == ConsoleModifiers.Control) Console.Write("CTL + ");
                Console.WriteLine(tecla.Key.ToString());

                if ((tecla.Modifiers & ConsoleModifiers.Control) != 0)
                {
                    salidaControl = true;

                    if ((tecla.Modifiers & ConsoleModifiers.Shift) != 0)
                    {
                        salidaShift = true;

                        if (tecla.Key.ToString() == "F")
                        {
                            salidaF = true;
                        }
                    }
                }

            } while (!salidaControl || !salidaShift || !salidaF);

        }
    }
}
