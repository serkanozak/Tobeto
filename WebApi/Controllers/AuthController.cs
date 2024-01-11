using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Auth.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private IMapper _mapper;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginAuthRequest request)
        {

            var userToLogin = await _authService.Login(request);
            var result = _authService.CreateAccessToken(userToLogin);
            return Ok(result);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterAuthRequest request)
        {
            //var userExists = _authService.UserExists(request.Email);

            //if (!userExists)
            //{
            //    return BadRequest(userExists);
            //}

            var registerResult = await _authService.Register(request, request.Password);

            return Ok(registerResult);
        }
    }
}
