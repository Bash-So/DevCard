using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 12,
        //        name = "Armin",
        //        job = "programmer",
        //        site = "mamadlearn.com"
        //    });
        //}
        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('Salam Chetowry')");
        //}

        public RedirectToActionResult Index()
        {
            return RedirectToAction("Contact", "Home");
        }

    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}