using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v0 = "İstatistikler";
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.v3 = context.Skills.Where(x => x.SkillValue >= 70).Count();
            ViewBag.v4 = context.Skills.Average(x => x.SkillValue);
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.Experiences.Where(x=>x.SubTitle == "Developer").Count();
            ViewBag.v7 = context.Services.Count();
            ViewBag.v8 = context.Testimonials.Where(x => x.Title == "Yazılım Mühendisi").Count();
            ViewBag.v9 = context.Categories.Count();
            ViewBag.v10 = context.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
