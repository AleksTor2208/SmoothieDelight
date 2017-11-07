using SmothieDelight_RecruitmentAssignment.Models;
using System.Web.Mvc;

namespace SmothieDelight_RecruitmentAssignment.Controllers
{
    public class HomeController : Controller
    {            
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SmoothieInfo()
        {
            return View();
        }       

        public ActionResult About()
        {
            ViewBag.Message = "Smoothie Delight is a branch new product line including healthy and usefull supplements.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contact us. Subscribe, so we could send you fresh news about our product!";

            return View();
        }
    }
}