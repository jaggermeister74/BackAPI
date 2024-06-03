using BackAPI.Entity;
using BackAPI.Models;
using BackAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUserService _userService;
        public UserController(ILogger logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("allusers")]
        public async Task<IActionResult> GetAllUser()
        {
            _logger.LogInformation("Получение всех пользователей.");

            return Ok(await _userService.GetAllUsers());
        }
        /*
        [HttpPost("addusers")]
        public async Task<IActionResult> AddUser([FromBody] UserModel user)
        {
            _logger.LogInformation("Добавление пользователя");

            return Ok(await _userService.AddUsers(user));
        }
        
        [HttpPost("removeusers")]
        public async Task<IActionResult> RemoveUsers()
        {
            _logger.LogInformation("Удаление пользователя");

            return Ok(await _userService.RemoveUsers());
        }
        */
    }
}
