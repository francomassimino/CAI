using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClases
{
    public class AlumnoRegular : Alumno
    {
        private string _email;

        public AlumnoRegular( int registro, string nombre, string apellido, string email) : base(registro, nombre, apellido)
        {
            this.Email = email;
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
    }
}
