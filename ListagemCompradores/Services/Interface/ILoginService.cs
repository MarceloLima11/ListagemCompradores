using ListagemCompradores.Models;
using ListagemCompradores.ViewModels;

namespace ListagemCompradores.Services.Interface
{
    public interface ILoginService
    {
        Cliente Login(LoginViewModel loginVM);
    }
}
