using System;
using System.Collections.Generic;

namespace Modelos
{
    public class Cliente
    {
        public Cliente()
        {
            Enderecos = new List<Endereco>();
            Contatos = new List<Contato>();
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Contato> Contatos { get; set; }
    }
}
