using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
       
            ILogic _logic;


            public CompanyController(ILogic log)
            {
                _logic = log;


            }
        [HttpGet("AllCompanyData")]
        public ActionResult Get()
        {
            try
            {
                var t = _logic.GetAllCompany();
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
        [HttpGet("FindTrainerByExperience")]
        public ActionResult FindTrainerByExperience(string Experience)
        {


            try
            {
                var s = _logic.FindTrainerByExperience(Experience);
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
                return BadRequest("No data found ");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddNewCompany")]
            public ActionResult Add(cdetail e)
            {
                try
                {
                    Log.Logger.Information("Added Trainer");
                    var tara = _logic.AddTrainerCompany(e);
                    return Created("AddTrainerCompany", tara);
                }
                catch (SqlException er)
                {
                    Log.Logger.Information("Could not exception");
                    return BadRequest("Enter proper details");
                }
                catch (Exception ex)
                {
                    Log.Logger.Information("Catch in Add Trainer");
                    return BadRequest(ex.Message);
                }


            }

        
       
        [HttpPut("UpdateCompanyDetails")]
        public ActionResult UpdateCompany(string EmailID, cdetail d)
        {
            try
            {
                if (!string.IsNullOrEmpty(EmailID))
                {
                    _logic.UpdateCompany(EmailID, d);
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

        [HttpGet("GetCompanyById/{EmailID}")]
        public IActionResult GetCompanyID([FromRoute] string EmailID)
        {
            string[] arr = EmailID.Split('@');
            string id = arr[0];
            try
            {
                var v = _logic.GetCompanyByID(id);
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
    }
}
