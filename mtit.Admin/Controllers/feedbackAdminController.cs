using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mtit.Admin.services;

namespace mtit.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class feedbackAdminController : Controller
    {

        // GET: feedbackAdminController

        private readonly Interfacefeedback _feedbackService;
        public feedbackAdminController(Interfacefeedback feedbackService)
        {
            _feedbackService = feedbackService ?? throw new ArgumentNullException(nameof(feedbackService));
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_feedbackService.Getfeedbacklist());
        }

        // GET: feedbackAdminController/Details/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _feedbackService.Getfeedback(id) != null ? Ok(_feedbackService.Getfeedback(id)) : NoContent();
        }

        
        [HttpPost]
        public ActionResult post([FromBody] models.feedback feedback)
        {
            return Ok(_feedbackService.Addfeedback(feedback));
        }


        [HttpPut]
        public IActionResult Put([FromBody] models.feedback feedback)
        {
            return Ok(_feedbackService.Updatefeedback(feedback));
        }


        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var result = _feedbackService.Deletefeedback(id);
            return result.HasValue & result == true ? Ok($"feedback order with Id:{id}got deleted successfully")
           : BadRequest($"unable to delete the feedback order with id :{id}");
     }

    }
}


