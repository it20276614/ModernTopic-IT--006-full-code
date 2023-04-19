using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using sliit.mtit.lecturer.services;
using sliit.mtit.lecturer.data;
using sliit.mtit.lecturer.services;



namespace Sliit.MTIT.lecturer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lecturerController : ControllerBase
    {
        private readonly Interfacelecturer _lecturerService;

        public lecturerController(Interfacelecturer lecturerService)
        {
            _lecturerService = lecturerService ?? throw new ArgumentNullException(nameof(lecturerService));
        }


        
        //get
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_lecturerService.Getlecturer());
        }

        //get
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _lecturerService.Getlecturer(id) != null ? Ok(_lecturerService.Getlecturer(id)) : NoContent();
        }

        //post
        [HttpPost]
        public IActionResult Post([FromBody] sliit.mtit.lecturer.models.lecturer lecturer)
        {
            return Ok(_lecturerService.Addlecturer(lecturer));
        }

        //update
        [HttpPut]
        public IActionResult Put([FromBody] sliit.mtit.lecturer.models.lecturer lecturer)
        {
            return Ok(_lecturerService.Updatelecturer(lecturer));
        }

        
        /// Delete 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _lecturerService.Deletelecturer(id);

            return result.HasValue & result == true ? Ok($"lecturer with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the lecturer with ID:{id}.");
        }
    }
}
    

