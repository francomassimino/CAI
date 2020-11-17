using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClases
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;

        public Asistencia(string fechaReferencia, DateTime fechaReal, Preceptor preceptor, Alumno alumno, bool presente)
        {
            this.FechaReferencia = fechaReferencia;
            this.FechaHoraReal = DateTime.Now;
            this.Preceptor = preceptor;
            this.Alumno = alumno;
            this.EstaPresente = presente;
        }
        public override string ToString()
        {
            string presente = "No";
            if (EstaPresente)
            {
                presente = "Si";
            }
            return $"FECHAREFERENCIA {Alumno.ToString()} está presente {presente} por {Preceptor.ToString()} registrado el {FechaHoraReal.ToString("AAAA-MM-DD")}";
        }
        public string FechaReferencia
        {
            get
            {
                return _fechaReferencia;
            }
            set
            {
                _fechaReferencia = value;
            }
        }

        public Alumno Alumno
        {
            get
            {
                return _alumno;
            }
            set
            {
                _alumno = value;
            }
        }

        public bool EstaPresente
        {
            get
            {
                return _estaPresente;
            }
            set
            {
                _estaPresente = value;
            }
        }

        public Preceptor Preceptor
        {
            get
            {
                return _preceptor;
            }
            set
            {
                _preceptor = value;
            }
        }

        public DateTime FechaHoraReal
        {
            get
            {
                return _fechaHoraReal;
            }
            set
            {
                _fechaHoraReal = value;
            }
        }

    }
}
