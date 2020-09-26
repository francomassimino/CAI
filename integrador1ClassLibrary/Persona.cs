using System;
using System.Collections.Generic;

namespace integrador1ClassLibrary
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        protected DateTime _fechaNac;
        
        protected Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public virtual string GetCredencial()
        {

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

        public int Edad
        {
            get
            {
                // implementar una solucion que tenga en cuenta meses y dias
                return DateTime.Now.Year - _fechaNac.Year;
            }
        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }
    }

    public class Alumno : Persona
    {
        private int _codigo;
        public Alumno(int codigo, string nombre, string apellido) : base(nombre, apellido)
        {
            Codigo = codigo;
        }

        public override string GetCredencial()
        {
            return Credencial;
        }

        public override string ToString()
        {
            return GetCredencial();
        }
        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        private string Credencial
        {
            get
            {
                return $"Código {Codigo}) {Apellido}, {Nombre}";
            }
        }

    }

    public abstract class Empleado : Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;

        public void AgregarSalario(Salario salario)
        {
            _salarios.Add(salario);
        }

        public override bool Equals(Object objeto)
        {
            Empleado empleado = objeto as Empleado;
            if (Legajo == empleado.Legajo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string GetCredencial()
        {
            Salario ultimoSalario = UltimoSalario();
            double ultimoSalarioNeto = ultimoSalario.Bruto - ultimoSalario.Descuentos;
            return $"{Legajo} - {GetNombreCompleto()} salario $ {ultimoSalarioNeto}";
        }

        public virtual string GetNombreCompleto()
        {

        }

        public override string ToString()
        {
            return GetCredencial();
        }


        protected Empleado(int legajo, string nombre , string apellido) : base(nombre, apellido)
        {
            Legajo = legajo;
        }

        
        public int Antiguedad
        {
            get
            {
                //implementar metodo que tenga en cuenta dias y meses
                return DateTime.Now.Year - _fechaIngreso.Year
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return _fechaIngreso;
            }
            set
            {
                _fechaIngreso = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNac;
            }
            set
            {
                _fechaNac = value;
            }
        }
        public int Legajo
        {
            get
            {
                return _legajo;
            }
            set
            {
                _legajo = value;
            }
        }

        public List<Salario> Salarios
        {
            get
            {
                return _salarios;
            }
        }

        public Salario UltimoSalario()
        {
            return Salarios[Salarios.Count - 1];
        }
    
    }

    public class Bedel : Empleado
    {
        string apodo;
        public Bedel(string apodo, int legajo, string nombre, string apellido, int ultimoSalarioNeto) : base(legajo, ultimoSalarioNeto, nombre, apellido)
        {
        }
        public override string GetNombreCompleto()
        {
            return $"Bedel {apodo}";
        }
    }

    public class Docente : Empleado
    {
        public Docente(int legajo, string nombre, string apellido, int ultimoSalarioNeto) : base(legajo, nombre, apellido)
        {
            
        }
        public override string GetNombreCompleto()
        {
            return $"Docente {Nombre}";
        }

    }

    public class Directivo : Empleado
    {
        public Directivo(int legajo, string nombre, string apellido, int ultimoSalarioNeto) : base(legajo, nombre, apellido)
        {

        }
        public override string GetNombreCompleto()
        {
            return $"Sr. Director {Apellido}";
        }
    }

    
    }
}
