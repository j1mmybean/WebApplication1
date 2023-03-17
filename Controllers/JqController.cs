using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class JqController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, HttpPost]
        public IActionResult Login(string username, string password)
        {           
            if (username == "hello" && password == "kitty")
                ViewData["LoginStatus"] = "pass";
            else
                ViewData["LoginStatus"] = "fail";

            return View();
        }
    }
}
