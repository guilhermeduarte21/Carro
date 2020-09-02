using Microsoft.AspNetCore.Mvc;

namespace Carro.Ui.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
