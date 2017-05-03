using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Endereco
    {
        [Key]
        public int ClienteId { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }

        [Timestamp]
        public byte[] Concorrencia { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
