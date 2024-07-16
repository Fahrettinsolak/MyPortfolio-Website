using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
		public IActionResult Index()
        {

            return View();
        }
    }
}
