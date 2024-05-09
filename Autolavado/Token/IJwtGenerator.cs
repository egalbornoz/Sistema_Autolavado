using Autolavado.Models;

namespace Autolavado.Token;

public interface IJwtGenerator
{
    string CrearToken(Usuario usuario);
}