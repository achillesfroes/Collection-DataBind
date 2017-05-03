using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Contato
    {
        [Key]
        public int ClienteId { get; set; }
        public string Conteudo { get; set; }
        public TipoContato Tipo { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        public virtual Cliente Cliente { get; set; }
    }

    public enum TipoContato
    {
        TelefoneFixo,
        Celular,
        Email
    }
}
