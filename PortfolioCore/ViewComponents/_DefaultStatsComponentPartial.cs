using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v0 = context.Testimonials.Count();
            ViewBag.v1 = context.Portfolios.Count();
            ViewBag.v2 = context.Skills.Count();
            Random rndNum = new Random();
            int randomNumbaer = rndNum.Next(10, 21);
            ViewBag.v3 = randomNumbaer;
            return View();
        }
    }
}
