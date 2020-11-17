using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaIndumentaria
{
    public class Camisa : Indumentaria
    {
        private string tipo_manga;
        private bool tiene_estampado;

        public override string GetDetalle()
        {
            string estampado;
            if (tiene_estampado)
            {
                estampado = "si";
            }
            else
            {
                estampado = "no";
            }
            return $"Camisa {Codigo} con manga {tipo_manga}, tiene estampado {estampado}. Stock: {Stock}. Talle {Talle}. Precio {Precio}";
        }
        public Camisa(string tipo_manga, bool tiene_estampado, int stock, string talle, double precio, TipoIndumentaria tipo) : base(stock, talle, precio, tipo )
        {
            this.TipoManga = tipo_manga;
            this.Tiene_Estampado = tiene_estampado;
        }
        public string TipoManga
        {
            get
            {
                return tipo_manga;
            }
            set
            {
                tipo_manga = value;
            }
        }

        public bool Tiene_Estampado
        {
            get
            {
                return tiene_estampado;
            }
            set
            {
                tiene_estampado = value;
            }
        }
    }
}
