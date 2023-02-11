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
                return BadRequest(er.Message);
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
                    return BadRequest(er.Message);
                }
                catch (Exception ex)
                {
                    Log.Logger.Information("Catch in Add Trainer");
                    return BadRequest(ex.Message);
                }


            }

        
       
        [HttpPut("UpdateCompanyDetails")]
        public ActionResult UpdateCompany(string user_id, cdetail d)
        {
            try
            {
                if (!string.IsNullOrEmpty(user_id))
                {
                    _logic.UpdateCompany(user_id, d);
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
