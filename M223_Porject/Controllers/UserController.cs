using M223_Porject.Dto;
using Microsoft.AspNetCore.Mvc;

namespace M223_Porject.Controllers;

[ApiController]
public class UserController : Controller
{
    [HttpPost("/login")]
    public IActionResult Login([FromBody] LoginDto loginDto)
    {
        return Ok();
    } 
    
    [HttpPost("/register")]
    public IActionResult Register([FromBody] RegisterDto loginDto)
    {
        return Ok();
    } 
}
