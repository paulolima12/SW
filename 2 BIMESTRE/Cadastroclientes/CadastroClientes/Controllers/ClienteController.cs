using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }
    }
}
