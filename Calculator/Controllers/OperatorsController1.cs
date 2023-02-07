using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class OperatorsController1 : Controller
    {
        public IActionResult Index()

        {
            return View();
        }
    }
}
