using System.Web.Mvc;

namespace AngularAspTesting.Controllers
{
    public class TemplatesController : Controller
    {
        public ActionResult EnterFeedback()
        {
            return PartialView("_EnterFeedback");
        }

        public ActionResult ConfirmFeedback()
        {
            return PartialView("_ConfirmFeedback");
        }

        public ActionResult NotFound()
        {
            return PartialView("_ConfirmFeedback");
        }
    }
}
