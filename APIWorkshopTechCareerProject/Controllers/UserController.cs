using APIWorkshopTechCareerProject.Application.Request;
using APIWorkshopTechCareerProject.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace APIWorkshopTechCareerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequestDto request)
        {
            var response = await _userService.CreateAsync(request);

            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SignIn(SignInRequestDto request)
        {
            var response = await _userService.SignAsUser(request);
            return Ok(response);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUserInformation()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return Unauthorized();
            var response = await _userService.GetUserInformation(int.Parse(userId));
            return Ok(response);
        }
    }
}
