using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
