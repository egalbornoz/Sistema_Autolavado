using System.Security.Claims;

namespace Autolavado.Token;

public class UsuarioSesion : IUsuarioSesion
{
    //Se inyecta el contexto HttpContext dentro de la clase
    private readonly IHttpContextAccessor _httpContextAccessor;
    public UsuarioSesion(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string ObtenerUsuarioSesion()
    {
        var userName = _httpContextAccessor.HttpContext!.User?.Claims?
                  .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

        return userName!;
    }
}