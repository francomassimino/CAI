using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaIndumentaria
{
    class VentaItem
    {
        private Indumentaria prenda;
        private int cantidad;

        public VentaItem(Indumentaria prenda, int cantidad)
        {
            this.Prenda = prenda;
            this.Cantidad = cantidad;
        }
        public double GetTotal()
        {
            return cantidad * prenda.Precio;
        }
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
        
        public Indumentaria Prenda
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
