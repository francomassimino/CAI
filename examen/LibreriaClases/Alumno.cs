using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClases
{
    public abstract class Alumno : Persona
    {
        private int _registro;

        internal override string Display()
        {
            return $"{Nombre} - {Registro}";
        }
        public Alumno(int registro, string nombre, string apellido) : base(nombre, apellido)
        {
            this.Registro = registro;
        }
        public int Registro
        {
            get
            {
                return _registro;
            }
            set
            {
                _registro = value;
            }
        }
    }
}
