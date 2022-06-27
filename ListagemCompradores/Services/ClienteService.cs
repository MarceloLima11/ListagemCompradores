using ListagemCompradores.Filter;
using ListagemCompradores.Models;
using ListagemCompradores.Pagination;
using ListagemCompradores.Repository.Interface;
using ListagemCompradores.Services.Interface;
using ListagemCompradores.ViewModels;
using System.Text;
using XSystem.Security.Cryptography;

namespace ListagemCompradores.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository cliente)
        {
            _clienteRepository = cliente;
        }

        public void Registrar(Cliente cliente)
        {
            if(cliente.Senha != cliente.ConfirmarSenha)
            {
                throw new Exception("As senhas não coincidem!");
            }

            cliente.InscricaoEstadual = cliente.InscricaoEstadual == null ? "" : cliente.InscricaoEstadual;
            cliente.Senha = GetSHA512(cliente.Senha);
            cliente.ConfirmarSenha = GetSHA512(cliente.ConfirmarSenha);

            var clienteExiste = _clienteRepository.GetClientes().Result.Where(
                x => x.Email.Equals(cliente.Email) ||
                x.CpfCnpj.Equals(cliente.CpfCnpj) ||
                x.TipoPessoa.Equals("Juridica") ? x.InscricaoEstadual.Equals(cliente.InscricaoEstadual) : false)?.FirstOrDefault();

            if (clienteExiste != null)
            {
                if (clienteExiste.Email.Equals(cliente.Email))
                {
                    throw new Exception("Este e-mail já está cadastrado para outro Cliente!");
                }
                if (clienteExiste.CpfCnpj.Equals(cliente.CpfCnpj))
                {
                    throw new Exception("Este CPF / CNPJ já está cadastrado para outro Cliente");
                }
                if (cliente.TipoPessoa.Equals("Juridica") ? clienteExiste.InscricaoEstadual.Equals(cliente.InscricaoEstadual) : false)
                {
                    throw new Exception("Esta Inscrição Estadual já está cadastrada para outro Cliente");
                }
            }

            _clienteRepository.AdicionarCliente(cliente);
        }

        public static string GetSHA512(string senha)
        {
            UnicodeEncoding UE = new UnicodeEncoding();

            byte[] HashValue, MessageBytes = ASCIIEncoding.UTF8.GetBytes(senha);

            SHA512Managed shaManaged = new SHA512Managed();

            HashValue = shaManaged.ComputeHash(MessageBytes);

            string strSha = string.Join("", HashValue.Select(x => string.Format("{0:x2}", x)));

            return strSha;
        }

        public async Task<PaginationModel> GetPaginatedResult(int currentPage, int pageSize = 20)
        {
            PaginationModel result = new PaginationModel();  
            List<ClienteViewModel> clienteViewModel = new List<ClienteViewModel>();   
            var clientes = await _clienteRepository.GetClientes();

            foreach (var cliente in clientes)
            {
                clienteViewModel.Add(new ClienteViewModel()
                {
                    Bloqueado = cliente.Bloqueado ? "Sim" : "Nao",
                    DataCadastro = cliente.DataCadastro.ToString("dd/MM/yyyy"),
                    Email = cliente.Email,
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Telefone = cliente.Telefone
                });
            }

            result.Data = clienteViewModel.OrderBy(d => d.Id).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            result.Count = clientes.Count();
            result.CurrentPage = currentPage;
            return result;
        }

        public async Task Update(Cliente cliente) 
        {
            var clienteExiste = await _clienteRepository.GetById(cliente.Id);

            if (clienteExiste == null)
                throw new Exception("Cliente não encontrado!");

            try 
            {
                clienteExiste.Bloqueado = cliente.Bloqueado;    
                clienteExiste.CpfCnpj = cliente.CpfCnpj;
                clienteExiste.Telefone = cliente.Telefone;  
                clienteExiste.TipoPessoa = cliente.TipoPessoa;
                clienteExiste.DataNascimento = cliente.DataNascimento;
                clienteExiste.Email = cliente.Email;
                clienteExiste.Genero = cliente.Genero;
                clienteExiste.InscricaoEstadual = cliente.InscricaoEstadual;
                clienteExiste.Isento = cliente.Isento;
                clienteExiste.Nome = cliente.Nome;
                _clienteRepository.Update(clienteExiste);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PaginationModel Filtrar(FiltroModel filter)
        {
            PaginationModel result = new PaginationModel();
            List<ClienteViewModel> clienteViewModel = new List<ClienteViewModel>();
            var clientes = _clienteRepository.GetClientes().Result.Where(i => 
            !String.IsNullOrEmpty(filter.Emaill) ? i.Email.Equals(filter.Emaill) : true &&
            !String.IsNullOrEmpty(filter.Nomee) ? i.Nome.Equals(filter.Nomee) : true &&
            !String.IsNullOrEmpty(filter.Telefonee) ? i.Telefone.Equals(filter.Telefonee) : true );

            if (clientes == null)    
                return result;  

            foreach (var cliente in filter.DataCadastroo.HasValue ? clientes.Where(i => 
            i.DataCadastro.Year.Equals(filter.DataCadastroo.Value.Year) &&
            i.DataCadastro.Month.Equals(filter.DataCadastroo.Value.Month) &&
            i.DataCadastro.Day.Equals(filter.DataCadastroo.Value.Day) &&
            i.Bloqueado.Equals(!filter.Bloqueadoo)) : clientes.Where(i => i.Bloqueado.Equals(filter.Bloqueadoo)))
            {
                clienteViewModel.Add(new ClienteViewModel()
                {
                    Bloqueado = cliente.Bloqueado ? "Sim" : "Nao",
                    DataCadastro = cliente.DataCadastro.ToString("dd/MM/yyyy"),
                    Email = cliente.Email,
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Telefone = cliente.Telefone
                });
            }

            result.Data = clienteViewModel;
            result.Count = clienteViewModel.Count(); 
            return result;
        }
    }
}
