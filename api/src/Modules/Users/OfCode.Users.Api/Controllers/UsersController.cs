using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OfCode.Users.Api.Controllers;

internal class UsersController : BaseController
{
    [Authorize]
    [HttpGet("{id:guid}")]
    public async Task<ActionResult> GetUser(Guid id)
    {
        return Ok();
    }
    
    [HttpPost]
    public async Task<ActionResult> SignUp()
    {
        return Ok();
    }
    
    [HttpPost]
    public async Task<ActionResult> SignIn()
    {
        return Ok();
    }
}