using Microsoft.AspNetCore.Mvc;

namespace aulaDotNetCore.Controllers
{
    [Route("[controller]/[action]")]
    public class ViewServicesController : Controller
    {
        public IActionResult Services(){

            return View();
        }
    }
}