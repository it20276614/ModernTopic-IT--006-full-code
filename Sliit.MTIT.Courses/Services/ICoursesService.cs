namespace Sliit.MTIT.Courses.Services
{
    public interface ICoursesService
    {
        List<Models.Courses> GetCourses();

        Models.Courses? GetCourses(int id);

        Models.Courses? AddCourses(Models.Courses courses);

        Models.Courses? UpdateCourses(Models.Courses courses);

        bool? DeleteCourses(int id);
    }
}
