
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Courses.Data;
using Sliit.MTIT.Courses.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesService _coursesService;

        public CoursesController(ICoursesService coursesService)
        {
            _coursesService = coursesService ?? throw new ArgumentNullException(nameof(coursesService));
        }


        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns>return the list of courses</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_coursesService.GetCourses());
        }

        /// <summary>
        /// Get courses by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the courses with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _coursesService.GetCourses(id) != null ? Ok(_coursesService.GetCourses(id)) : NoContent();
        }

        /// <summary>
        /// Add students
        /// </summary>
        /// <param name="courses"></param>
        /// <returns>Return the added courses</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Courses courses)
        {
            return Ok(_coursesService.AddCourses(courses));
        }

        /// <summary>
        /// Update the student
        /// </summary>
        /// <param name="courses"></param>
        /// <returns>Return the updated student</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Courses courses)
        {
            return Ok(_coursesService.UpdateCourses(courses));
        }

        /// <summary>
        /// Delete the student with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _coursesService.DeleteCourses(id);

            return result.HasValue & result == true ? Ok($"courses with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the courses with ID:{id}.");
        }
    }
}
