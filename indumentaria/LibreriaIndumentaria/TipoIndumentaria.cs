using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaIndumentaria
{
    public abstract class TipoIndumentaria
    {
        private string origen;
        private double porcentaje_algodon;

        protected TipoIndumentaria(string origen, double porcentaje_algodon)
        {
            this.origen = origen;
            this.porcentaje_algodon = porcentaje_algodon;
        }

        public string Origen
        {
            get
            {
                return origen;
            }
            set
            {
                origen = value;
            }
        }

        public double Porcentaje_Algodon
        {
            get
            {
                return porcentaje_algodon;
            }
            set
            {
                porcentaje_algodon = value;
            }
        }

    }
}
