using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClases
{
    public class Preceptor : Persona
    {
        private int _legajo;
        
        public Preceptor(int legajo, string nombre, string apellido) : base(nombre, apellido)
        {
            this.Legajo = legajo;
        }

        internal override string Display()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{Apellido} - {Legajo}";
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
    }
}
