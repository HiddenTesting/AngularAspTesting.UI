using System.Web.Mvc;

namespace AngularAspTesting.Controllers
{
    public class TemplatesController : Controller
    {
        public ActionResult EnterFeedback()
        {
            return PartialView("_EnterFeedback");
        }

        public ActionResult FeedbackResponse()
        {
            return PartialView("_FeedbackResponse");
        }

        public ActionResult NotFound()
        {
            return PartialView("_NotFound");
        }
    }
}
