using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;
using BusinessLogic;
using Microsoft.Extensions.Caching.Memory;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        ILogic _logic;
        

        public EducationController(ILogic log)
        {
            _logic = log;
           

        }
        [HttpGet("GetEducationById/{EmailID}")]
        public IActionResult GetEducationById([FromRoute]string EmailID)
        {
            string[] arr= EmailID.Split('@');
            string id= arr[0];
            try
            {
                var v = _logic.GetEducationById(id);
                return Ok(v);
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
        [HttpGet("AllEducationData")]
        public ActionResult Get()
        {
            try
            {
                var t = _logic.GetAllEducation();
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

        [HttpPost("AddNewEducation")]
        public ActionResult Add(Edetail e)
        {
            try
            {
                Log.Logger.Information("Added Trainer");
                var tara = _logic.AddTrainerEducation(e);
                return Created("AddTrainerEducation", tara);
            }
            catch (SqlException er)
            {
                Log.Logger.Information("Could not exception");
                return BadRequest("Add proper details");
            }
            catch (Exception ex)
            {
                Log.Logger.Information("Catch in Add Trainer");
                return BadRequest("Add Proper details");
            }


        }

        [HttpPut("UpdateEducation")]
        public ActionResult UpdateEducation(string EmailID, Edetail d)
        {
            try
            {
                if (!string.IsNullOrEmpty(EmailID))
                {
                    _logic.UpdateEducation(EmailID, d);
                    return Ok(d);
                }
                else
                {
                    return BadRequest($"Please check your input");
                }
            }
            catch (SqlException er)
            {
                return BadRequest("No Data found with this Email");
            }
            catch (Exception ex)
            {
                return BadRequest("No data with this email");
            }

        }
       
    }
}
