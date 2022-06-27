using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListagemCompradores.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        [Required]
        public string TipoPessoa { get; set; }
        [Required]
        [StringLength(maximumLength: 18, MinimumLength = 14)]
        public string CpfCnpj { get; set; }
        public string InscricaoEstadual { get; set; } = "";
        [Required]
        public string Genero { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public bool Bloqueado { get; set; }
        public bool Isento { get; set; }
        [Required]
        [StringLength(200)]
        public string Senha { get; set; }
        [NotMapped] // <== Já tenho a senha salva no banco!
        [StringLength(200)]
        public string ConfirmarSenha { get; set; }
    }
}
