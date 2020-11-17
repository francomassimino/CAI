using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Banco.Entidades
{
    [DataContract]
    public class Cuenta
    {
        private int _nroCuenta;
        private string _descripcion;
        private int _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;
        private int _id;

        public Cuenta(int nroCuenta, string descripcion, int saldo, DateTime fechaApertura, DateTime fechaModificacion, bool activo, int idCLiente, int id)
        {
            NroCuenta = nroCuenta;
            Descripcion = descripcion;
            Saldo = saldo;
            FechaApertura = fechaApertura;
            FechaModificacion = fechaModificacion;
            Activo = activo;
            IdCliente = idCLiente;
            Id = id;
        }

        [DataMember]
        public int NroCuenta
        {
            get
            {
                return _nroCuenta;
            }
            set
            {
                _nroCuenta = value;
            }
        }

        [DataMember]
        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion= value;
            }
        }

        [DataMember]
        public int Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        [DataMember]
        public DateTime FechaApertura
        {
            get
            {
                return _fechaApertura;
            }
            set
            {
                _fechaApertura = value;
            }
        }

        [DataMember]
        public DateTime FechaModificacion
        {
            get
            {
                return _fechaModificacion;
            }
            set
            {
                _fechaModificacion = value;
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
        public int IdCliente
        {
            get
            {
                return _idCliente;
            }
            set
            {
                _idCliente = value;
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
