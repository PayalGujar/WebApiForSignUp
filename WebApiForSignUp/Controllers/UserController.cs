using Microsoft.AspNetCore.Mvc;
using WebApiForSignUp.Models;
using WebApiForSignUp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiForSignUp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

   
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        public UserController(IUserService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("GetUsers")]

        public async Task<IActionResult> Get()
        {
            try
            {
                var model = await service.GetUsers();
                return new ObjectResult(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("AddUser")]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                int result = await service.AddUser(user);
                if(result>=1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
