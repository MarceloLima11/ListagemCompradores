using Hanssens.Net;
using ListagemCompradores.Filter;
using ListagemCompradores.Models;
using ListagemCompradores.Repository.Interface;
using ListagemCompradores.Services.Interface;
using ListagemCompradores.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ListagemCompradores.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ILoginService _loginService;
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteRepository clienteRepository, ILoginService loginService, IClienteService clienteService)
        {
            _clienteRepository = clienteRepository;
            _loginService = loginService;
            _clienteService = clienteService;
        }
        public async Task<IActionResult> List(int currentPage, int pageSize = 20)
        {
            var logado = false;

            logado = bool.Parse(HttpContext.Session.GetString("login") != null ? HttpContext.Session.GetString("login") : "false");

            if (logado)
            {
                var clientes = await _clienteService.GetPaginatedResult(currentPage, pageSize);
                ViewData["Clientes"] = clientes;
                return View("../Cliente/List");
            }
            else
            {
                return View("../Home/Index");
            }
        }

        public IActionResult Filtrar(FiltroModel filter)
        {            
            var clientes = _clienteService.Filtrar(filter);
            ViewData["Clientes"] = clientes;
            return View("../Cliente/List");
        }

        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            try
            {
                var cliente = _loginService.Login(loginVM);

                if (cliente == null)
                    return View("../Home/Index");

                HttpContext.Session.SetString("login", "true");

                return await List(1, 20);
            }
            catch(Exception e)
            {
                ViewData["Message"] = e.Message;

                return View("../Home/Index");
            }
        }

        [HttpPost] 
        public async Task<IActionResult> Registrar(Cliente cliente) 
        {
            try 
            {
                _clienteService.Registrar(cliente);

                return await List(1, 20);
            }
            catch (Exception e)
            {
                ViewData["Message"] = e.Message;

                return View("../Cliente/Registrar");
            }
        }

        public IActionResult Registrar() 
        {
            return View("../Cliente/Registrar");
        }

        public async Task<IActionResult> LimparFiltros(int currentPage, int pageSize = 20) 
        {
            var logado = true;

            logado = bool.Parse(HttpContext.Session.GetString("login") != null ? HttpContext.Session.GetString("login") : "false");

            if (logado)
            {
                var clientes = await _clienteService.GetPaginatedResult(currentPage, pageSize);
                ViewData["Clientes"] = clientes;
                return View("../Cliente/List");
            }
            else
            {
                return View("../Home/Index");
            }
        }

        public async Task<IActionResult> Editar(int id) 
        {
            if(id == 0)
            {
                return NotFound();
            }

            var cliente = await _clienteRepository.GetById(id);

            if(cliente == null)
            {
                return View("../Cliente/List");
            }

            return View("../Cliente/Editar", cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Cliente cliente)
        {
            try
            {
                await _clienteService.Update(cliente);

                return await List(1, 20);
            }
            catch (Exception e)
            {
                ViewData["Message"] = e.Message;

                return await Editar(cliente.Id);
            }
        }
    }
}

