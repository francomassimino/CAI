using System;
using System.Collections.Generic;

namespace LibreriaClases
{
    public class Presentismo
    {
        private List<Alumno> _alumnos = new List<Alumno>();
        private List<Asistencia> _asistencias = new List<Asistencia>();
        private List<Preceptor> _preceptores = new List<Preceptor>();
        private List<string> _fechas = new List<string>();

        public Presentismo()
        {
            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));

            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));
        }

        public Preceptor GetPreceptorActivo()
        {
            return _preceptores[0];
        }
        private bool AsistenciaRegistrada(string fecha)
        {
            ///buscar asistencia por fecha
            if(ListaAlumnos)
                ///me fijo el largo de la lista si es 0 entonces devulevo lanzo la excepcion de sin alumnos registrados, caso contrario devuelvo true
        }

        private int GetCantidadAlumnosRegulares()
        {
            int cantidad = 0;
            foreach(Alumno item in GetListaAlumnos())
            {
                if (item is AlumnoRegular)
                {
                    cantidad = cantidad + 1;
                }
            }
            return cantidad;
        }

        public List<Alumno> GetListaAlumnos(string nombre)
        {
            List<Alumno> lista_alumnos = new List<Alumno>;

            foreach(Alumno item in _alumnos)
            {
                if (item.Nombre.ToLower() == nombre.ToLower())
                {
                    lista_alumnos.Add(item);
                }
            }
            return _alumnos;
        }

        public void AgregarAsistencia(List<Asistencia> asistencias, string fecha)
        {
            _asistencias = asistencias;
            _fechas.Add(fecha);
        }

        public List<Asistencia> Asistencia
        {
            get
            {
                return _asistencias;
            }
        }

        public List<Alumno> ListaAlumnos
        {
            get
            {
                return _alumnos;
            }
        }
    }
}
