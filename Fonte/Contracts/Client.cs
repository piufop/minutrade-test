using System;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public DateTime DataNascimento { get; set; }

        [DataMember]
        public string TelefoneCelular { get; set; }
    }
}
