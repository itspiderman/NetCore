using Microsoft.AspNetCore.Mvc;
//
using WebDemo.Models;
using Dalclasslib.com.mvc.bll;

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
        public IActionResult FundSearch(FundModel fundIndex)
        {
            System.Console.WriteLine();
            Dalclasslib.com.mvc.bll.TfundBLL tfundbll = new TfundBLL();
            Dalclasslib.com.mvc.entity.TfundEntity tfundEntity = tfundbll.Get(fundIndex.fundCode);
            if (tfundEntity != null)
            {
                ViewBag.Message = tfundEntity.fundName + " fund is found";
            }
            else
            {
                ViewBag.Message = "No fund found!";
            }
            return View(fundIndex);
            //return View("default");
        }
    }
}
