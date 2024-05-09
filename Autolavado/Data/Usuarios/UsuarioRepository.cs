using Autolavado.Dtos.UsuarioDtos;
using Autolavado.Models;
using Autolavado.Token;
using Microsoft.AspNetCore.Identity;

namespace Autolavado.Data.Usuarios;

public class UsuarioRepository : IUsuarioRepository
{

    private readonly UserManager<Usuario> _userManager;
    private readonly SignInManager<Usuario> _signInManager;
    private readonly IJwtGenerator _jwtGenerador;
    private readonly AppDbContext _context;
    private readonly IUsuarioSesion _usuarioSesion;


    public UsuarioRepository(
        UserManager<Usuario> userManager,
        SignInManager<Usuario> signInManager,
        IJwtGenerator jwtGenerator,
        AppDbContext context,
        IUsuarioSesion usuarioSesion
    )
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _jwtGenerador = jwtGenerator;
        _usuarioSesion = usuarioSesion;
        _context = context;
    }

    private UsuarioResponseDto TransformerUserToUserDto(Usuario usuario)
    {
        return new UsuarioResponseDto
        {
            Id = usuario.Id,
            Nombre = usuario.Id,
            Apellido = usuario.Apellido,
            Telefono = usuario.Telefono,
            Email = usuario.Email,
            UserName = usuario.UserName,
            Token = _jwtGenerador.CrearToken(usuario)
        };

    }
    public async Task<UsuarioResponseDto> GetUsuario()
    {
        var usuario = await _userManager.FindByNameAsync(_usuarioSesion.ObtenerUsuarioSesion());
        return TransformerUserToUserDto(usuario!);
    }

    public async Task<UsuarioResponseDto> Login(UsuarioLoginRequestDto request)
    {
        var usuario = await _userManager.FindByEmailAsync(request.Email!);
        await _signInManager.CheckPasswordSignInAsync(usuario!, request.Password!, false);
        return TransformerUserToUserDto(usuario!);
    }

    public async Task<UsuarioResponseDto> RegistroUsuario(UsuarioRegistroRequestDto request)
    {
        var usuario = new Usuario
        {
            Nombre = request.Nombre,
            Apellido = request.Apellido,
            Telefono = request.Telefono,
            Email = request.Email,
            UserName = request.UserName,

        };
        await _userManager.CreateAsync(usuario!, request.Password!);
        return TransformerUserToUserDto(usuario);
    }
}