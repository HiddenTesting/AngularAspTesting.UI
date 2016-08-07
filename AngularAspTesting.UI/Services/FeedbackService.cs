using System.Collections.Generic;
using System.Linq;
using AngularAspTesting.Models;

namespace AngularAspTesting.Services
{
    public class FeedbackService
    {
        private static readonly List<EnterFeedbackModel> EnterFeedbackModels = new List<EnterFeedbackModel>();

        public int SaveNew(EnterFeedbackModel enterFeedbackModel)
        {
            enterFeedbackModel.Id = EnterFeedbackModels.Count + 1;

            EnterFeedbackModels.Add(enterFeedbackModel);

            return enterFeedbackModel.Id;
        }

        public EnterFeedbackModel Get(int id)
        {
            return EnterFeedbackModels.FirstOrDefault(i => i.Id == id);
        }

        public List<EnterFeedbackModel> GetAll()
        {
            return EnterFeedbackModels;
        } 
    }
}
