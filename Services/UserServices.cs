namespace prueba_ilogger_bp.Services;

public class UserServices : IUserServices
{

    private readonly ILogger<UserServices> logger;

    public UserServices(ILogger<UserServices> logger)
    {
        this.logger = logger;
    }
    public string GetUser(string cedula)
    {
        logger.LogInformation("Obtener datos");
        var listUser = new List<User>();
        listUser.Add(new User("Cesar", "123213432"));

        var search = listUser.Where(x => x.Cedula.Contains(cedula));
        var cedulaEncrypted = System.Text.Encoding.UTF8.GetBytes(cedula);
        logger.LogError(Convert.ToBase64String(cedulaEncrypted));
        logger.LogError("salio mal");
        return $"||Metodo GET||cedula:{Convert.ToBase64String(cedulaEncrypted)}||CODIGO 404";

    }
}