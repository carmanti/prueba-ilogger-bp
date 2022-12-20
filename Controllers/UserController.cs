using Microsoft.AspNetCore.Mvc;
using prueba_ilogger_bp.Services;

namespace prueba_ilogger_bp.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserServices services;

    public UserController(IUserServices services)
    {
        this.services = services;
    }

    [HttpGet]
    public string GetUser([FromQuery] string cedula)
    {
        // var cedula = "161616166";
        // var cedulaEncrypted = System.Text.Encoding.UTF8.GetBytes(cedula);
        return services.GetUser(cedula);
    }
}