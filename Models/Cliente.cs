using System.ComponentModel.DataAnnotations.Schema;

namespace testeMvc.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Column("Nome")]
        public string NomeCliente { get; set; }

        [Column("Telefone")]
        public string TelefoneCliente { get; set; }

    }
}
