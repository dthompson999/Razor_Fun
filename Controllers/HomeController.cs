using Microsoft.AspNetCore.Mvc;
namespace razor_fun
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}