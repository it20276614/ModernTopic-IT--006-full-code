namespace Sliit.MTIT.Courses.Data
{
    public class CoursesMockDataService
    {
        public static List<Models.Courses> Course = new List<Models.Courses>()
        {
            new Models.Courses {Id = 1, Coursename = "IP", Credit = 5, EnrollId = "IT4025"},
            new Models.Courses {Id = 2, Coursename = "OOP", Credit = 6, EnrollId = "IT2145"},
            new Models.Courses {Id = 3, Coursename = "MTIT", Credit = 4, EnrollId = "IT5647"},
            new Models.Courses {Id = 4, Coursename = "SQA", Credit = 6, EnrollId = "IT2012"},
            new Models.Courses {Id = 5, Coursename = "IWT", Credit = 4, EnrollId = "IT2015"},
        };
    }
}
