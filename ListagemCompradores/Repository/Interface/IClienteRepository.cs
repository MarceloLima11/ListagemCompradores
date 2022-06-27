using ListagemCompradores.Models;
using ListagemCompradores.ViewModels;

namespace ListagemCompradores.Repository.Interface
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes();

        Cliente GetLogin(LoginViewModel loginVM);

        void AdicionarCliente(Cliente cliente);

        Task<Cliente> GetById(int id);

        void Update(Cliente cliente);
    }
}
