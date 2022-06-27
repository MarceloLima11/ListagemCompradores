using System.ComponentModel.DataAnnotations;

namespace ListagemCompradores.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string DataCadastro { get; set; } 
        public string Bloqueado { get; set; }
    }
}
