using System.Web.Http;
using AngularAspTesting.Models;

namespace AngularAspTesting.Controllers
{
    //[Authorize]
    public class FeedbackController : ApiController
    {
        [HttpGet]
        public int Get()
        {
            return 31;
        }

        [HttpPost]
        public void Post(EnterFeedbackModel enterFeedbackModel)
        {

        }
    }
}
