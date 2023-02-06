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
        /*      [HttpGet("AllTrainerData")]
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
              }*/
        [HttpGet("GetAllTrainerData")]
        public ActionResult Getall() {

            try
            {
                var t = _logic.getAllTrainerdatas();
                if(t.Count()>0)
                {
                    Log.Logger.Information("GetALlcalled");


                    return Ok(t);
                }
                else
                {
                    Log.Logger.Information("GetAllCalled");
                    return BadRequest("No data found in database");
                }
            }
            catch (SqlException e)
            {
                Log.Logger.Information("Could not  found");
                    
                return BadRequest("Could not found");
            }
            catch (Exception e)
            {


                Log.Logger.Information("Error");
                return BadRequest(e.Message);
            }
        }

        [HttpPost("AddTrainer")]
        public ActionResult Add(Trainerdata e)
        {
            try
            {
                Log.Logger.Information("Added Trainer");
                var tara = _logic.AddTrainer(e);
                return CreatedAtAction("AddTrainer", tara);
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

        [HttpDelete("DeleteTrainer")]
        public ActionResult Delete(string Name)
        {
            try
            {
                if(!string.IsNullOrEmpty(Name))
                {
                    var r=_logic.DeleteTrainer(Name);
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
                return BadRequest(er.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}