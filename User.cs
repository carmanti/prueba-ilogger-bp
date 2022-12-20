using System.Runtime.CompilerServices;
using System.Globalization;
namespace prueba_ilogger_bp;
public class User
{
    public User(string Nombre, string cedula)
    {
        this.Nombre = Nombre;
        this.Cedula = cedula;

    }

    public string Nombre { get; set; }
    public string Cedula { get; set; }

}