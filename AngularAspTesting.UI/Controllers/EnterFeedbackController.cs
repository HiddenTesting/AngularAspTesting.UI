using System.Web.Http;
using AngularAspTesting.Models;
using AngularAspTesting.Services;

namespace AngularAspTesting.Controllers
{
    public class EnterFeedbackController : ApiController
    {
        private FeedbackService _feedbackService;
        private FeedbackService FeedbackService => _feedbackService ?? (_feedbackService = new FeedbackService());
        
        [Authorize]
        [HttpPost]
        public int Post(EnterFeedbackModel enterFeedbackModel)
        {
            return FeedbackService.SaveNew(enterFeedbackModel);
        }
    }
}
