using System.Reflection;
namespace mtit.Admin.services
{
    public interface Interfacefeedback
    {
        
        
            List<models.feedback> Getfeedbacklist();
            models.feedback? Getfeedback(int id);
            models.feedback? Addfeedback(models.feedback feedback);
            models.feedback? Updatefeedback(models.feedback feedback );
            bool? Deletefeedback(int id);
        }
    }

