using System;
using System.Collections.Generic;
using System.Text;

namespace integrador1ClassLibrary
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;
        public void AgregarAlumno(Alumno alumno)
        {
            _alumnos.Add(alumno);
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            _empleados.Add(empleado);
        }

        public void EliminarAlumno(int codigo)
        {
            for (int x = 0; x < this._alumnos.Count; x++){
                if(this._alumnos[x].Codigo == codigo)
                {
                    this._alumnos.RemoveAt(x);
                    break;
                }
            }
        }

        public void EliminarEmpleado(int legajo)
        {
            for (int x = 0; x < this._empleados.Count; x++)
            {
                if (this._empleados[x].Legajo == legajo)
                {
                    this._alumnos.RlemoveAt(x);
                    break;
                }
            }
        }

        public void ModificarEmpleado(Empleado empleado)
        {
            Empleado nuevosDatos = empleado as Empleado;
            try
            {
                Empleado empleadoEditar = TraerEmpleadosPorLegajo(nuevosDatos.Legajo);
                empleadoEditar.Apellido = nuevosDatos.Apellido;
                empleadoEditar.Nombre = nuevosDatos.Nombre;
                empleadoEditar.FechaNacimiento = nuevosDatos.FechaNacimiento;
                empleadoEditar.FechaIngreso = nuevosDatos.FechaIngreso;
            }
            catch
            {
                //capturar excepcion de empleado no encontrado por legajo
            }

        }

        public List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }

        public Empleado TraerEmpleadosPorLegajo(int legajo)
        {
            Empleado empleado;
            for (int x = 0; x < this._empleados.Count; x++)
            {
                if (this._empleados[x].Legajo == legajo)
                {
                    empleado = this._empleados[x];
                    return empleado;
                }
            }
            //lanzar exception de empleado no encontrado
        }

        public List<Empleado> TraerEmpleados()
        {
            return _empleados;
        }

        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
            List<Empleado> empleadosPedidos = new List<Empleado>();
            for (int x = 0; x < this._empleados.Count; x++)
            {
                if (this._empleados[x].Nombre == nombre)
                {
                    empleadosPedidos.Add(this._empleados[x]);
                }
            }
            return empleadosPedidos;
        }


        public int CantidadSedes
        {
            get
            {
                return _cantidadSedes;
            }
            set
            {
                _cantidadSedes = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
    }
}
