using Banco.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Banco.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("/cliente"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        private List<Cliente> MapList(string json2)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json2);
            return lst;
        }

        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("/api/v1/cliente", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Dni", cliente.Dni.ToString());
            n.Add("Direccion", cliente.Direccion);
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaNacimiento", cliente.FechaNacimiento.ToString());
            n.Add("FechaAlta", cliente.FechaAlta.ToString());
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("Usuario", cliente.Usuario);
            n.Add("Host", cliente.Host);
            n.Add("Usuario", cliente.Usuario);
            n.Add("Id", cliente.Id.ToString());

            return n;
        }
    }
}
