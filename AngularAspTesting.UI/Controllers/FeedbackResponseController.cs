using System.Web.Http;
using AngularAspTesting.Models;
using AngularAspTesting.Services;

namespace AngularAspTesting.Controllers
{
    public class FeedbackResponseController : ApiController
    {
        private FeedbackService _feedbackService;
        private FeedbackService FeedbackService => _feedbackService ?? (_feedbackService = new FeedbackService());

        /// <summary>
        /// Returns the details of a feedback entry
        /// </summary>
        /// <param name="id">The Id of the model</param>
        /// <returns>A response model</returns>
        [HttpPost]
        public EnterFeedbackModel Get(int id)
        {
            return this.FeedbackService.Get(id);
        }
    }
}
