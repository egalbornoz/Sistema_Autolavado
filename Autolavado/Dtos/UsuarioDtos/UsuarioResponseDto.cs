namespace Autolavado.Dtos.UsuarioDtos;

//Se filtra la data deseada que se enviara al usuario, la dto me sirve para
// filtrar la data requerida
public class UsuarioResponseDto
{
    public string? Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Token { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? Telefono { get; set; }
}