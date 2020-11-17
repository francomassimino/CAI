using Banco.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Banco.Datos
{
    class CuentaMapper
    {
        public List<Cuenta> TraerTodos()
        {
            string json2 = WebHelper.Get("/cuenta"); // trae un texto en formato json de una web
            List<Cuenta> resultado = MapList(json2);
            return resultado;
        }

        private List<Cuenta> MapList(string json2)
        {
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(json2);
            return lst;
        }

        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);
            string result = WebHelper.Post("/api/v1/cuenta", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("NroCuenta", cuenta.NroCuenta.ToString());
            n.Add("Descripcion", cuenta.Descripcion);
            n.Add("Saldo", cuenta.Saldo.ToString());
            n.Add("FechaApertura", cuenta.FechaApertura.ToString());
            n.Add("FechaApertura", cuenta.FechaModificacion.ToString());
            n.Add("Activo", cuenta.Activo.ToString());
            n.Add("IdCliente", cuenta.IdCliente.ToString());
            n.Add("Id", cuenta.Id.ToString());

            return n;
        }
    }
}
