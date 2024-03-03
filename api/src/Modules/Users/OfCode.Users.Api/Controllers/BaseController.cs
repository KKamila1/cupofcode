using Microsoft.AspNetCore.Mvc;

namespace OfCode.Users.Api.Controllers;

[ApiController]
[Route("[controller]")]
internal class BaseController : ControllerBase
{
    protected ActionResult<T> OkOrNotFound<T>(T model)
    {
        if (model is null)
        {
            return NotFound();
        }

        return Ok(model);
    }
}