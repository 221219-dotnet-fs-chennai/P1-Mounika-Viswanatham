using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        ILogic _logic;
        public TrainerController(ILogic log)
        {
            _logic = log;

        }
        [HttpGet("AllTrainerData")]
        public ActionResult Get()
        {
            try
            {
                var t = _logic.AllTrainerData();
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

        [HttpPost("AddTrainer")]
        public ActionResult Add(Trainerdata e)
        {
            try
            {
                var tara = _logic.AddTrainer(e);
                return CreatedAtAction("AddTrainer", tara);
            }
            catch (SqlException er)
            {
                return BadRequest(er.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("FindTrainerByEmailID")]
        public ActionResult FindTrainerByEmailID(string EmailID)
        {


            try
            {
                var s = _logic.FindTrainerByEmailID(EmailID);
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
                return BadRequest(er.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("FindTrainerByLocation")]
        public ActionResult FindTrainerByLocation(string Location)
        {


            try
            {
                var s = _logic.FindTrainerByLocation(Location);
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
                return BadRequest(er.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateTrainer")]
        public ActionResult UpdateTrainer(string Name,Trainerdata d)
        {
            try
            {
                if(!string.IsNullOrEmpty(Name))
                {
                    _logic.UpdateTrainer(Name, d);
                    return Ok(d);
                }
                else
                {
                    return BadRequest($"Please check your input");
                }
            }
            catch (SqlException er)
            {
                return BadRequest(er.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}