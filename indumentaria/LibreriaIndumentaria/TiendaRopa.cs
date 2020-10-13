using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaIndumentaria
{
    public class TiendaRopa
    {
        private List<Indumentaria> _Inventario;
        private List<Venta> _Ventas;
        private int _ultimo_codigo=0;

        private int GetProximoCodigo()
        {
            return _ultimo_codigo + 1;
        }

        public void Agregar(Indumentaria indumentaria)
        {
            indumentaria.Stock=3;
            indumentaria.Codigo = GetProximoCodigo();
            _Inventario.Add(indumentaria);
            _ultimo_codigo = GetProximoCodigo();
        }

        public void Modificar(Indumentaria indumentaria)
        {
            Indumentaria cambio;
            foreach(Indumentaria item in _Inventario)
            {
                if (item.Equals(indumentaria))
                {
                    cambio = item;
                    break;
                }
            }
            cambio = indumentaria;
        }

        public void Quitar(Indumentaria indumentaria)
        {
            foreach(Indumentaria item in _Inventario)
            {
                if (item.Equals(indumentaria))
                {
                    _Inventario.Remove(item);
                }
            }
        }

        public void IngresarOrden(Venta venta)
        {
            venta.Estado = 1;
        }

        public List<Indumentaria> Listar()
        {
            return _Inventario;
        }

        public List<Venta> ListarVenta()
        {
            return _Ventas;
        }

        public void DevolverOrden(Venta venta)
        {
            venta.Estado = 3;
        }
    }
}
