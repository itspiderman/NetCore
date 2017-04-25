using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDemo.Controllers
{
    public class FundController : Controller
    {
        // GET: /<controller>/
        public IActionResult FundIndex()
        {
            return View();
        }
    }
}
