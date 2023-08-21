using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using testeMvc.Models;
using testeMvc.TesteContext;

namespace testeMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            var cli = _context.Clientes.FirstOrDefault(c => c.NomeCliente == cliente.NomeCliente);

            if (cli != null)
                {
                ViewBag.DadosCliente = cli;
                    return View();
                }
                else
                {
                    ViewBag.Mensagem = "Cliente não encontrado";
                    return View();
                }
          

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}