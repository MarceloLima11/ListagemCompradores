using ListagemCompradores.Models;
using ListagemCompradores.Repository.Interface;
using ListagemCompradores.Services.Interface;
using ListagemCompradores.ViewModels;
using System.Text;
using XSystem.Security.Cryptography;

namespace ListagemCompradores.Services
{
    public class LoginService : ILoginService
    {
        private readonly IClienteRepository _cliente;
        public LoginService(IClienteRepository cliente)
        {
            _cliente = cliente; 
        }

        public Cliente Login(LoginViewModel loginVM)
        { 
            loginVM.Senha = GetSHA512(loginVM.Senha);
            var cliente = _cliente.GetLogin(loginVM);

            if (cliente == null) 
            {
                throw new Exception("Usuário inexistente!");
            } 
            else if (cliente.Bloqueado.Equals(true))
            {
                throw new Exception("Usuário bloqueado!");
            }
            else 
            {
                return cliente;
            }

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
    }
}
