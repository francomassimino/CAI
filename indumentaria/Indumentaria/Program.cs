using System;
using LibreriaIndumentaria;

namespace EjercicioIndumentaria
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaRopa tienda = new TiendaRopa();
            bool continuar = true;
            int opcion;
            string menu = "Ingrese: \n1) Listar Indumentarias \n2) Agregar Indumentaria \n3) Modificar Indumentaria \n4) Eliminar Indumentaria \n5) Listar Ordenes \n6) Ingresar Orden \n7) Devolver Orden \n8) Salir";



            Console.WriteLine("Bienvenido");

            do
            {
                Console.WriteLine(menu);
                opcion = Validacion.PedirEntero(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        foreach(Indumentaria item in tienda.Listar())
                        {
                            item.GetDetalle();
                        }
                        break;
                    case 2:
                        TipoIndumentaria t_indumentaria;

                        do
                        {                            
                            string origen = Validacion.PedirString("Ingrese origen");
                            double porcentaje_algodon = Validacion.PedirDouble("Ingrese porcentaje de algodon");

                            int tipo = Validacion.PedirEntero("Ingrese tipo de indumentaria: \n1) Deportiva \n2) Casual \n3) Formal");
                            

                            switch (opcion)
                            {
                                case 1:
                                    t_indumentaria = new IndumentariaDeportiva(origen, porcentaje_algodon);
                                    continuar = false;
                                    break;
                                case 2:
                                    t_indumentaria = new IndumentariaCasual(origen, porcentaje_algodon);
                                    continuar = false;
                                    break;
                                case 3:
                                    t_indumentaria = new IndumentariaFormal(origen, porcentaje_algodon);
                                    continuar = false;
                                    break;
                                default:
                                    Console.WriteLine("");
                                    break;
                            }
                        } while (continuar);
                        continuar = true;

                        do
                        {
                            string talle;
                            

                            int stock = Validacion.PedirEntero("Ingrese el stock");

                            do
                            {
                                talle = Validacion.PedirString("Ingrese talle: L, M o S");
                                if (talle.ToLower() == "l" && talle.ToLower() == "m" && talle.ToLower() == "s")
                                {
                                    continuar = false;
                                }
                                else
                                {
                                    continuar = true;
                                    Console.WriteLine("Opcion Incorrecta");
                                }
                            } while (continuar);
                            continuar = true;

                            double precio = Validacion.PedirDouble("Ingrese el precio");

                            opcion = Validacion.PedirEntero("Ingrese: \n1) Camisa \n2) Pantalon");
                            switch (opcion)
                            {
                                case 1:
                                    bool estampado = Validacion.PedirBool("Tiene estampado?");
                                    string tipo_manga = Validacion.PedirString("Ingresar tipo manga");
                                    tienda.Agregar(new Camisa(tipo_manga, estampado, stock, talle, precio, t_indumentaria));
                                    break;

                                case 2:
                                    string material = Validacion.PedirString("Ingrese material");
                                    bool bolsillos = Validacion.PedirBool("Tiene bolsillos?");
                                    tienda.Agregar(new Pantalon(material, bolsillos, stock, talle, precio, t_indumentaria));
                                    break;
                                default:
                                    Console.WriteLine("Opicon Incorrecta");
                                    break;
                            }
                        } while (continuar);
                        continuar = true;
                        Console.WriteLine("Prenda agregada...");
                        break;
                    case 8:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }
            } while (continuar);
            Console.WriteLine("Hasta luego!");
        }
    }
}
