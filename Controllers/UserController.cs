using Microsoft.AspNetCore.Mvc;

namespace prueba_ilogger_bp.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> GetEncryptedCedula()
    {
        var cedula = "161616166";
        var cedulaEncrypted = System.Text.Encoding.UTF8.GetBytes(cedula);
        return Convert.ToBase64String(cedulaEncrypted);
    }
}