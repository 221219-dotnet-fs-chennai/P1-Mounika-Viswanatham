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

        [HttpGet("AllSkillsData")]
        public ActionResult Get()
        {
            try
            {
                var t = _logic.GetAllSkills();
                if (t.Count() > 0)
                {

                    return Ok(t);

                }
                else
                {
                    return BadRequest("No data");
                }
            }
            catch (SqlException e)
            {
                return BadRequest("Could not found");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost("AddNewSkill")]
        public ActionResult Add(Sdetail e)
        {
            try
            {
                Log.Logger.Information("Added Trainer");
                var tara = _logic.AddTrainerSkill(e);
                return Created("Skill are added", tara);
            }
            catch (SqlException er)
            {
                Log.Logger.Information("Could not exception");
                return BadRequest("add proper details");
            }
            catch (Exception ex)
            {
                Log.Logger.Information("Catch in Add Trainer");
                return BadRequest(ex.Message);
            }


        }

        

        [HttpPut("UpdateTrainer")]
        public ActionResult UpdateSkill(string EmailID, Sdetail d)
        {
            try
            {
                if (!string.IsNullOrEmpty(EmailID))
                {
                    _logic.UpdateSkill(EmailID, d);
                    return Ok(d);
                }
                else
                {
                    return BadRequest($"Please check your input");
                }
            }
            catch (SqlException er)
            {
                return BadRequest("check your input");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("FindTrainerBySkill/{SkillName}")]
        public ActionResult FindTrainerBySkill([FromRoute] string SkillName)
        {


            try
            {
                var s = _logic.FindTrainerBySkill(SkillName);
                if (s != null)
                {
                    return Ok(s);
                }
                else
                {
                    return NotFound("Trainer not found");
                }

            }
            catch (SqlException er)
            {
                return BadRequest("no data found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
