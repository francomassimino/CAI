using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Banco.Entidades
{
    [DataContract]
    public class TransactionResult
    {
        [DataMember]
        public bool IsOk { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Error { get; set; }
    }
}
