using ListagemCompradores.Filter;
using ListagemCompradores.Models;
using ListagemCompradores.Pagination;
using ListagemCompradores.ViewModels;

namespace ListagemCompradores.Services.Interface
{
    public interface IClienteService
    {
        void Registrar(Cliente cliente);
        Task<PaginationModel> GetPaginatedResult(int currentPage, int pageSize = 20);

        PaginationModel Filtrar(FiltroModel filter);
        Task Update(Cliente cliente);
    }
}
