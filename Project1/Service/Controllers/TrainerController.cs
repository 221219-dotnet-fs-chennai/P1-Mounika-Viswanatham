using BusinessLogic;
using FluentAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        ILogic _logic;
        IMemoryCache  _mem;

        public TrainerController(ILogic log,IMemoryCache o)
        {
            _logic = log;
            _mem = o;

        }

        [HttpGet("Login")]
        public ActionResult Login(string EmailID, string Password)
        {
            try
            {
                if (!string.IsNullOrEmpty(EmailID))
                {
                    var tara = _logic.Login(EmailID, Password);
                    if (tara)
                    {
                        return Ok("Successfully logined");
                        

                    }
                    else
                    {
                        return BadRequest("Please check your email and password");
                    }
                }
                else
                {
                    return BadRequest("Please check your EmailID");
                }


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
        [HttpGet("GetAllTrainerData")]
        public ActionResult Getall() {

            try
            {
                var t = _logic.getAllTrainerdatas();
                if(t.Count()>0)
                {
                    


                    return Ok(t);
                }
                else
                {
                   
                    return BadRequest("No data found in database");
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
       
        [HttpPost("AddNewTrainer")]
        public ActionResult AddNewTrainer([FromBody]Trainerdata e)
        {
            try
            {
               
                var tara = _logic.AddTrainer(e);
                return Created("AddTrainer", tara);
            }
            catch (SqlException er)
            {
              
                return BadRequest("add correct details");
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex.Message);
            }


        }
       
       

        [HttpGet("FindTrainerByEmailID/{EmailID}")]
        public IActionResult FindTrainerByEmailID([FromRoute]string EmailID)
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
                return BadRequest("No data found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("FindTrainerByLocation/{Location}")]
        public ActionResult FindTrainerByLocation([FromRoute]string Location)
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
                return BadRequest("No data found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateTrainer")]
        public ActionResult UpdateTrainer(string Email,Trainerdata d)
        {
            try
            {
                if(!string.IsNullOrEmpty(Email))
                {
                    _logic.UpdateTrainer(Email, d);
                    return Ok(d);
                }
                else
                {
                    return BadRequest($"Please check your EmailID");
                }
            }
            catch (SqlException er)
            {
                return BadRequest("No data found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("DeleteTrainer")]
        public ActionResult Delete(string EmailID)
        {
            try
            {
                if(!string.IsNullOrEmpty(EmailID))
                {
                    var r=_logic.DeleteTrainer(EmailID);
                    if (r != null)
                        return Ok(r);
                    else
                        return NotFound();
                }
                else
                { 
                    return BadRequest("Please add a correct value  to be deleted");
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