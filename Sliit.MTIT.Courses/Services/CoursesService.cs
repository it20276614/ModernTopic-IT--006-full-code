using Sliit.MTIT.Courses.Data;
using Sliit.MTIT.Courses.Models;

namespace Sliit.MTIT.Courses.Services
{
    public class CoursesService : ICoursesService
    {
        public List<Models.Courses> GetCourses()
        {
            return CoursesMockDataService.Course;
        }

        public Models.Courses? GetCourses(int id)
        {
            return CoursesMockDataService.Course.FirstOrDefault(x => x.Id == id);
        }

        public Models.Courses? AddCourses(Models.Courses courses)
        {
            CoursesMockDataService.Course.Add(courses);
            return courses;
        }

        public Models.Courses? UpdateCourses(Models.Courses courses)
        {
            Models.Courses selectedCourses = CoursesMockDataService.Course.FirstOrDefault(x => x.Id == courses.Id);
            if (selectedCourses != null)
            {
                selectedCourses.EnrollId = courses.EnrollId;
                selectedCourses.Credit = courses.Credit;
                selectedCourses.Coursename = courses.Coursename;
                return selectedCourses;
            }

            return selectedCourses;
        }

        public bool? DeleteCourses(int id)
        {
            Models.Courses selectedCourses = CoursesMockDataService.Course.FirstOrDefault(x => x.Id == id);
            if (selectedCourses != null)
            {
                CoursesMockDataService.Course.Remove(selectedCourses);
                return true;
            }
            return false;
        }

    }
}
