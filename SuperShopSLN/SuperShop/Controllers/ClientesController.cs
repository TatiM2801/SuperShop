using Microsoft.AspNetCore.Mvc;
using SuperShop.Models;

namespace SuperShop.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Detalhe()
        {

            Cliente cliente = new Cliente()
            {
                ClienteId = 200,
                Nome = "Tatiana",
                Email = "tatiana.moraes@gmail.com",
                Telefone = "966966523",


            };

            return View(cliente);
        }
    }
}
