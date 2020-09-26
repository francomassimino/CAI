using integrador1ClassLibrary;
using System;
using System.Collections.Generic;

namespace integrador1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string alta = "1";
            const string modificacion = "2";
            const string baja = "3";
            const string listar = "4";
            Facultad facultad = new Facultad();
            bool salir = false;
            int opcion;

            Console.WriteLine("Hello World!");

            do
            {
                Console.WriteLine($"Ingrese:\n {alta} para alta\n {modificacion} para modificacion\n {baja} para baja\n {listar} para listar");
                opcion = ValidarEntero();
                switch (opcion)
                {
                    case 1:
                        // menu alta
                        break;
                    case 2:
                        // menu modificacion
                        break;
                    case 3:
                        // menus baja
                    case 4:
                        //menu listar
                    default:
                        Console.WriteLine("Opción inexistente...");
                        break;

                }



            } while (!salir);



        }

        private static int ValidarEntero()
        {
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }
    
    }
}
