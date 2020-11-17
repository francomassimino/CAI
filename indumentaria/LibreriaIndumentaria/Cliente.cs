using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaIndumentaria
{
    class Cliente
    {
        private int codigo;
        private string apellido;
        private string nombre;

        public Cliente(int codigo, string apellido, string nombre)
        {
            this.Codigo = codigo;
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
    }
}
