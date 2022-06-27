using ListagemCompradores.Context;
using ListagemCompradores.Models;
using ListagemCompradores.Repository.Interface;
using ListagemCompradores.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ListagemCompradores.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ListagemDbContext _context;

        public ClienteRepository(ListagemDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
        }

        public Cliente GetLogin(LoginViewModel loginVM)
        {
            return _context.Clientes.Where(c => c.Email.Equals(loginVM.Email) && c.Senha.Equals(loginVM.Senha)).FirstOrDefault();
        }

        public async Task<Cliente> GetById(int id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Update(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.Update(cliente);
            _context.SaveChanges();
        }
    }
}
