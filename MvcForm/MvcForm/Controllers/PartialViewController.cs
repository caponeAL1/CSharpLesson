using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcForm.Controllers
{
    public class PartialViewController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry Are Good Friends";
            return View();
        }

    } 
}
