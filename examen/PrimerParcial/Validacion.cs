using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.MASSIMINO.Escuela
{
    public class Validacion
    {
        public static int PedirEntero(string mensaje)
        {
            int resultado;
            do
            {
                if (int.TryParse(Console.ReadLine(), out resultado))
                {
                    return resultado;
                }
                else
                {
                    Console.WriteLine("Input invalido");
                }
            } while (true);
            
        }

        public static bool PedirBooleano(string mensaje)
        {
            bool opcion;
            Console.WriteLine(mensaje);
            do
            {
                switch (Validacion.PedirEntero(mensaje))
                {
                    case 1:
                        opcion = true;
                        break;
                    case 2:
                        opcion = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (true);
        }
    }
}
