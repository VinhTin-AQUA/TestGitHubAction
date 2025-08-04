using Microsoft.AspNetCore.Mvc;
using TestGithubAction.Models;
using TestGithubAction.Services;

namespace TestGithubAction.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }
        
        // GET
        public IActionResult GetUserById(string id)
        {
            var user = userService.GetUserById(id);
            return Ok(user);
        }

        public IActionResult AddUser([FromBody] User user)
        {
            userService.AddUser(user);
            return Ok(user);
        }
    }
}