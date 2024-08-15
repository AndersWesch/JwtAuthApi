
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers;

public class HomeController : ControllerBase
{
    [Authorize]
    [HttpGet("userinfo")]
    public IActionResult GetUserInfo()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var username = User.Identity?.Name;

        return Ok(new
        {
            UserId = userId,
            Username = username
        });
    }
}
