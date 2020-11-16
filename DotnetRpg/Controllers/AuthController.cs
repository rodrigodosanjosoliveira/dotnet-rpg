using System.Threading.Tasks;
using DotnetRpg.Data;
using DotnetRpg.Dtos;
using DotnetRpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetRpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepo.Register(
                new User {Username = request.Username }, request.Password
            );
            if(!response.Success) 
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}