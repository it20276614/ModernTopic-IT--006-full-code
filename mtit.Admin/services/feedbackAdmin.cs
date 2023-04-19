using mtit.Admin.models;
using mtit.Admin.data;



namespace mtit.Admin.services
{
    public class feedbackAdmin:Interfacefeedback



    {


        public models.feedback? Getfeedback(int id)
        {
            return feedbackAdmindataservice.feedback.FirstOrDefault(x => x.studentId == id);


        } 

        public List<models.feedback> Getfeedbacklist()
        {
            return feedbackAdmindataservice.feedback;
        }



        public models.feedback? Addfeedback(models.feedback feedback)
        {
            feedbackAdmindataservice.feedback.Add(feedback);
            return feedback;
        }



        



        public models.feedback? Updatefeedback(models.feedback feedback)
        {
            models.feedback selectedfeedback = feedbackAdmindataservice.feedback.FirstOrDefault(x => x.studentId == feedback.studentId);
            if (selectedfeedback != null)
            {
                selectedfeedback.studentName = feedback.studentName;
                selectedfeedback.Address = feedback.Address;
                selectedfeedback.Comment = feedback.Comment;
                return selectedfeedback;
            }

            return selectedfeedback;
        }

        public bool? Deletefeedback(int id)
        {
            models.feedback selectedfeedback = feedbackAdmindataservice.feedback.FirstOrDefault(x => x.studentId == id);
            if (selectedfeedback != null)
            {
                feedbackAdmindataservice.feedback.Remove(selectedfeedback);
                return true;
            }
            return false;
        }

        
        }
    }
