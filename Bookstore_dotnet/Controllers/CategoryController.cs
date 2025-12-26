using Microsoft.AspNetCore.Mvc;
using Bookstore_dotnet.Models;

namespace Bookstore_dotnet.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            // TODO: Fetch and display categories
            return View();
        }
    }
}
