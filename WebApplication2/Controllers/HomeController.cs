using Microsoft.AspNetCore.Mvc;
using WebApplication2.Views.Contexts;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var db = new SizeDBContext();
            var sizes = db.sizes.ToList();

            return Json(sizes);


        }


    }
}
