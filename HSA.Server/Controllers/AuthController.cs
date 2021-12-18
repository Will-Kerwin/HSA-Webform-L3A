using HSA.Server.Exceptions.Auth;
using HSA.Server.Repository;
using HSA.Shared.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSA.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthRepo Auth;

        public AuthController(IAuthRepo auth)
        {
            Auth = auth;
        }

        [HttpPost("Register/User")]
        public async Task<IActionResult> RegisterUser()
        {
            return await Task.FromResult(Ok());
        }

        [HttpPost("Register/Employee")]
        public async Task<IActionResult> RegisterEmployee()
        {
            return await Task.FromResult(Ok());
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel body)
        {
            try 
            {
                UserModel user = await Auth.LoginUser(body);
                string token = await Auth.GenerateToken(user);
                return Ok(new
                {
                    User = user,
                    Token = token
                });
            }
            catch (EmployeeNotFoundException enfe)
            {
                return Unauthorized(enfe.Message);
            }
            catch(IncorrectPasswordException pwe)
            {
                return Unauthorized(pwe.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
