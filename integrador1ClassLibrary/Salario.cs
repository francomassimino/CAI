using System;
using System.Collections.Generic;
using System.Text;

namespace integrador1ClassLibrary
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public double GetSalarioNeto()
        {
            return Bruto - Descuentos;
        }

        public Salario(double bruto, string codigoTransferencia, double descuentos, DateTime fecha)
        {
            Bruto = bruto;
            CodigoTransferencia = codigoTransferencia;
            Descuentos = descuentos;
            Fecha = fecha;
        }

        public double Bruto
        {
            get
            {
                return _bruto;
            }
            set
            {
                _bruto = value;
            }
        }

        public string CodigoTransferencia
        {
            get
            {
                return _codigoTransferencia;
            }
            set
            {
                _codigoTransferencia = value;
            }
        }

        public double Descuentos
        {
            get
            {
                return _descuentos;
            }
            set
            {
                _descuentos = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }

    }
}
