using System;

namespace LibreriaIndumentaria
{
    public abstract class Indumentaria
    {
        private TipoIndumentaria tipo;
        private int codigo;
        private int stock;
        private string talle;
        private double precio;

        protected Indumentaria(int stock, string talle, double precio, TipoIndumentaria tipo)
        {
            this.Stock = stock;
            this.Talle = talle;
            this.Precio = precio;
            this.Tipo = tipo;
        }

        public override bool Equals(object obj)
        {
            Indumentaria indumentaria = obj as Indumentaria;
            if (this.Codigo == indumentaria.Codigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return GetDetalle();
        }
        public abstract string GetDetalle();

        public TipoIndumentaria Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
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

        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }

        public string Talle
        {
            get
            {
                return talle;
            }
            set
            {
                talle = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
    }

}
