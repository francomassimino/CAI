using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioIndumentaria
{
    class Validacion
    {
        public static int PedirEntero(string mensaje)
        {
            int numero;
            Console.WriteLine(mensaje);
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }

        public static double PedirDouble(string mensaje)
        {
            double numero;
            bool continuar=true;
            Console.WriteLine(mensaje);
            do
            {
                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Valor incorrecto");
                }
            } while (continuar);
            
        }
        public static bool PedirBool(string mensaje)
        {
            bool continuar = true;
            int opcion = Validacion.PedirEntero(mensaje);
            Console.WriteLine("Ingrese 1 para 'Si' o 2 para 'No' ");
            do
            {
                switch (opcion)
                {
                    case 1:
                        return true;
                    case 2:
                        return false;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (continuar);

        }

        public static string PedirString(string mensaje)
        {
            Console.WriteLine(mensaje);
            bool continuar = true;
            do
            {
                string ingreso = Console.ReadLine();
                double numero;
                if (!double.TryParse(ingreso, out numero))
                {
                    return ingreso;
                }
                else
                {
                    Console.WriteLine("Input incorrecto");
                }
            } while (continuar);
            

        }
    }

       
}
