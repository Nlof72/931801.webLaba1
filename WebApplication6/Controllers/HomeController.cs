using Microsoft.AspNetCore.Mvc;
using WebApplication6.ViewModels;

namespace WebApplication6.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PassUsingModel()
        {
            var viewModel = new NumsOperation();
            return View(viewModel);
        }
        public IActionResult PassUsingViewData()
        {

            ViewData["Nums"] = new NumsOperation();
            return View();
        }
        public IActionResult PassUsingViewBag()
        {
            ViewBag.Nums = new NumsOperation();
            return View();
        }
        public IActionResult AccessServiceDirectly()
        {
            return View();
        }

    }
}
