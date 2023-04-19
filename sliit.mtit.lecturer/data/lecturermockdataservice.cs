using System.Reflection;

namespace sliit.mtit.lecturer.data
{
    public class lecturermockdataservice
    {
        public static List<models.lecturer> lecturer = new List<models.lecturer>()
        {
            new models.lecturer { Id = 1, Name = "kavin", Address = "123 Main St", Age = 40 },
            new models.lecturer { Id = 2, Name = "Mary", Address = "456 Second Ave", Age = 52 },
            new models.lecturer { Id = 3, Name = "nipun", Address = "789 Third St", Age = 31 },
            new models.lecturer { Id = 4, Name = "Kate", Address = "321 Fourth Ave", Age = 43 },
            new models.lecturer { Id = 5, Name = "Miker", Address = "654 Fifth St", Age = 29 }

        };

    }
}
