using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : Controller
    {
        ILogic _logic;


        public SkillController(ILogic log)
        {
            _logic = log;


        }

        [HttpPost("AddTrainerSkill")]
        public ActionResult Add(Sdetail e)
        {
            try
            {
                Log.Logger.Information("Added Trainer");
                var tara = _logic.AddTrainerSkill(e);
                return Created("AddTrainerSkill", tara);
            }
            catch (SqlException er)
            {
                Log.Logger.Information("Could not exception");
                return BadRequest(er.Message);
            }
            catch (Exception ex)
            {
                Log.Logger.Information("Catch in Add Trainer");
                return BadRequest(ex.Message);
            }


        }
    }
}
