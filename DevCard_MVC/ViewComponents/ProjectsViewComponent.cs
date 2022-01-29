using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "تاکسی", " درخواست آنلاین تاکسی هوایی","project-1.jpg", "ShahroozHavaii"),
                new Project(2, "بدفود", "  درخواست غذای هوایی", "project-2.jpg","ShahroozGhazaii"),
                new Project(3, "مودچوب", " درخواست چوب هوایی", "project-3.jpg","ShahroozChoobi"),
                new Project(4, "کلاس", " درخواست آنلاین کلاس هوایی", "project-4.jpg","ShahroozBaKelas"),
            };
            return View("_Projects", projects);
        }

    }
}
