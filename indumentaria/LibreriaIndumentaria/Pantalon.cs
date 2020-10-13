using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaIndumentaria
{
    public class Pantalon : Indumentaria
    {
        private string material;
        private bool tiene_bolsillos;

        public override string GetDetalle()
        {
            string bolsillos;
            if (tiene_bolsillos)
            {
                bolsillos = "si";
            }
            else
            {
                bolsillos = "no";
            }
            return $"Pantalon {Codigo} de {material}, tiene bolsillos {bolsillos}. Stock: {Stock}. Talle {Talle}. Precio {Precio}";
        }
        public Pantalon(string material, bool tiene_bolsillos, int stock, string talle, double precio, TipoIndumentaria tipo) : base(stock, talle, precio, tipo)
        {
            this.Material = material;
            this.Tiene_Bolsillos = tiene_bolsillos;
        }
        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }

        public bool Tiene_Bolsillos
        {
            get
            {
                return tiene_bolsillos;
            }
            set
            {
                tiene_bolsillos = value;
            }
        }
    }
}
