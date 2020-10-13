using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaIndumentaria
{
    class VentaItem
    {
        private Indumentaria prenda;
        private int cantidad;

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
        
        public Indumentaria Penda
        {
            get
            {
                return prenda;
            }
            set
            {
                prenda = value;
            }
        }
    }
}
