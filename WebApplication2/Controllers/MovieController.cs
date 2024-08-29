using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult GetMovie(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie with id = {id}";
            //result.ContentType = "object/pdf" ;
            //result.StatusCode = 200 ;

            return Content($"Movie with id = {id}", "text/html");
        }

        public IActionResult Index()
        {
            //return RedirectToAction(nameof(GetMovie), new {id = 10});
            return RedirectToRoute("default", new {controller = "Product",action = "GetProduct", id = 100});
        }
    }
}
