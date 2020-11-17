using System;
using System.Collections.Generic;
using LibreriaClases;

namespace Parcial1.MASSIMINO.Escuela
{
    public class Program
    {
        private static Presentismo _presentismo;
        static void Main(string[] args)
        {
            Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();
            bool continuar = true;

            do
            {
                DesplegarOpcionesMenu();
                string opcionMenu = Console.ReadLine(); // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        continuar = false;
                        break;
                    default:
                        break;
                }
            } while (continuar);
            
        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {

            List<Asistencia> nuevaAsistencia = new List<Asistencia>();
            // Ingreso fecha
            string fecha;    
            int day;
            int month;
            int year;
            day = Validacion.PedirEntero("Ingrese dia");
            month = Validacion.PedirEntero("Ingrese mes");
            year = Validacion.PedirEntero("Ingrese año");

            fecha = $"{year}-{month}-{day}";
                
                // Listar los alumnos

            foreach(Alumno item in _presentismo.ListaAlumnos)
            {
                if(item is AlumnoRegular)
                {

                    bool presente = Validacion.PedirBooleano("Ingrese 1 para presente, 2 para ausente");
                    Asistencia asistencia = new Asistencia(fecha, DateTime.Now, p, item, presente);
                    nuevaAsistencia.Add(asistencia);
                       
                }

            }

            _presentismo.AgregarAsistencia(nuevaAsistencia, fecha);
                // para cada alumno solo preguntar si está presente
                // agrego la lista de asistencia
                // Error: mostrar el error y que luego muestre el menu nuevamente
        }
        static void MostrarAsistencia()
        {
            int day;
            int month;
            int year;
            
            // ingreso fecha

            day = Validacion.PedirEntero("Ingrese dia");
            month = Validacion.PedirEntero("Ingrese mes");
            year = Validacion.PedirEntero("Ingrese año");
            // muestro el toString de cada asistencia

            foreach(Asistencia item in _presentismo.Asistencia)
                {
                    if (item.FechaReferencia == $"{year}-{month}-{day}" && item.EstaPresente && item.Alumno is AlumnoRegular)
                    {
                        Console.WriteLine(item.Alumno.ToString());
                    }
                }
        }
    }
}
