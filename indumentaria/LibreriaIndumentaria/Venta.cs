using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaIndumentaria
{
    public class Venta
    {
        private List<VentaItem> items;
        private Cliente cliente;
        private int estado;
        private int codigo;

        public double GetTotalPedido()
        {
            double total=0;
            foreach (VentaItem item in items)
            {
                total = total + item.GetTotal();
            }
            return total;
        }
        public Venta(List<VentaItem> items, Cliente cliente, int estado, int codigo)
        {
            this.Items = items;
            this.Cliente = cliente;
            this.Estado = estado;
            this.Codigo = codigo;
        }
        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }
        public List<VentaItem> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
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

        public int Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
    }
}
