using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SocaialMediaController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult SocialMediaList()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                context.SocialMedias.Add(socialMedia);
                context.SaveChanges();
                return RedirectToAction("SocialMediaList");
            }
            return View(socialMedia);
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var socialMedia = context.SocialMedias.Find(id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            return View(socialMedia);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                context.SocialMedias.Update(socialMedia);
                context.SaveChanges();
                return RedirectToAction("SocialMediaList");
            }
            return View(socialMedia);
        }
    }
}
