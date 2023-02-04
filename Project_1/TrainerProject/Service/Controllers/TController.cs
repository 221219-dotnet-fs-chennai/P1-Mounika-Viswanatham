using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bussiness;
using Microsoft.Data.SqlClient;
namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TController : ControllerBase
    {
        IBusiness _bus;
        public TController(IBusiness business)
        {
            _bus = business;
        }
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var tra = _bus.GetTrainerDisconnected();
                if (tra.Count() > 0)
                {
                    return Ok(tra);
                }
                else
                {
                    return BadRequest("No data  found");
                }
            }
            catch (SqlException e)
            {
                return BadRequest($"Could not find {e.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FindTrainerByEmailID")]
        public ActionResult GetByEmailID(string EmailID)
        {

            try
            {
                var tra = _bus.FindTrainerByEmail(EmailID);
                if (tra!=null)
                {
                    return Ok(tra);
                }
                else
                {
                    return BadRequest("No data  found");
                }
            }
            catch (SqlException e)
            {
                return BadRequest($"Could not find {e.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("FindTrainerByLocation")]
        public ActionResult GetByLocation(string Location)
        {

            try
            {
                var tra = _bus.FindTrainerByLocation(Location);
                if (tra != null)
                {
                    return Ok(tra);
                }
                else
                {
                    return BadRequest("No data  found");
                }
            }
            catch (SqlException e)
            {
                return BadRequest($"Could not find {e.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /*[HttpDelete("DeleteTrainer")]
        public ActionResult Delete(string name)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var rest = _bus.RemoveTrainerByName(name);
                    if (rest != null)
                        return Ok(rest);
                    else
                        return NotFound();
                }
                else
                    return BadRequest("Please add a valid restaurant name to be deleted");

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }*/
    }
}
