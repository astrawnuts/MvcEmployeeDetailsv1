using Microsoft.AspNetCore.Mvc;

namespace MvcEmployeeDetails.Controllers
{
    public class NewEmployeeDetails : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
