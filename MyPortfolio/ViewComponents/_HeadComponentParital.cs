using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _HeadComponentParital:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
