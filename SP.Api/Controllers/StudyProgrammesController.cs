using Microsoft.AspNetCore.Mvc;
using SP.Api.Data;

namespace SP.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudyProgrammesController : ControllerBase
    {
        SPContext _context;
        public StudyProgrammesController(SPContext context) 
        { 
            _context = context;
        }
        
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {

            return Ok(_context.StudyProgrammes.ToList());
        }
    }
}
