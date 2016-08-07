using System.Web.Mvc;
using AngularAspTesting.Services;

namespace AngularAspTesting.Controllers
{
    public class HomeController : Controller
    {
        private FeedbackService _feedbackService;
        private FeedbackService FeedbackService => _feedbackService ?? (_feedbackService = new FeedbackService());
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewEntries()
        {
            return View();
        }
    }
}
