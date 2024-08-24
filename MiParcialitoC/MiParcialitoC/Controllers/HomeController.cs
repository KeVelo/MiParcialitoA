using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        return RedirectToAction("Menu");
    }

    public IActionResult Menu()
    {
        return View();
    }
}
