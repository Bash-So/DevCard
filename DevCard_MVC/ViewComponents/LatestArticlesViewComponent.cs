using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "آموزش ASP.Net Core MVC", "ممد در پکیج آموزشی", "blog-post-thumb-card-1.jpg"),
                new Article(2, "آموزش Git & Github", "ممد در پکیج آموزشی", "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش C# & Formatting", "ممد در پکیج آموزشی", "blog-post-thumb-card-3.jpg"),
                new Article(4, "آموزش طراحی سایت", "ممد در پکیج آموزشی", "blog-post-thumb-card-4.jpg"),
            };
            return View("_LatestArticles", articles);
        }
    }
}