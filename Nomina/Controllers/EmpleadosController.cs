using Microsoft.AspNetCore.Mvc;

namespace Nomina.Controllers
{
    public class EmpleadosController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
