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

            [HttpPost("AddTrainerCompany")]
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

        
    }
}
