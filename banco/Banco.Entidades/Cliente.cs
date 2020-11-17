using System;
using System.Runtime.Serialization;

namespace Banco.Entidades
{
    [DataContract]
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _direccion;
        private string _email;
        private string _telefono;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;
        private string _usuario;
        private string _host;
        private int _id;

        public Cliente(string nombre, string apellido, int dni, string direccion, string email, string telefono, DateTime fechaNacimiento, DateTime fechaAlta, bool activo, string usuario, string host, int id)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Email = email;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            FechaAlta = fechaAlta;
            Activo = activo;
            Usuario = usuario;
            Host = host;
            Id = id;
        }

        [DataMember]
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

        [DataMember]
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

        [DataMember]
        public int Dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }

        [DataMember]
        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        [DataMember]
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

        [DataMember]
        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        [DataMember]
        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }

        [DataMember]
        public DateTime FechaAlta
        {
            get
            {
                return _fechaAlta;
            }
            set
            {
                _fechaAlta = value;
            }
        }

        [DataMember]
        public bool Activo
        {
            get
            {
                return _activo;
            }
            set
            {
                _activo = value;
            }
        }

        [DataMember]
        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        [DataMember]
        public string Host
        {
            get
            {
                return _host;
            }
            set
            {
                _host = value;
            }
        }

        [DataMember]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
}
