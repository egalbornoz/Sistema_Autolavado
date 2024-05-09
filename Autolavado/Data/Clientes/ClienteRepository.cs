using Autolavado.Models;
using Autolavado.Token;
using Microsoft.AspNetCore.Identity;

namespace Autolavado.Data.Clientes;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _context;
    private readonly IUsuarioSesion _usuarioSesion;
    private readonly UserManager<Usuario> _userManager;

    //Inyectamos el DBContext

    public ClienteRepository(
        AppDbContext context,
        IUsuarioSesion sesion,
        UserManager<Usuario> userManager
        )
    {
        _context = context;
        _usuarioSesion = sesion;
        _userManager = userManager;
    }

    //---------------------------------------------------------------
    //    Método para crear el cliente 
    //---------------------------------------------------------------

    public async Task CreateClienteAsync(Cliente cliente)
    {
        var usuario = await _userManager.FindByNameAsync(_usuarioSesion.ObtenerUsuarioSesion());

        cliente.Fecha_Creacion = DateTime.Now;
        cliente.UsuarioId = Guid.Parse(usuario!.Id);

        _context.Clientes!.Add(cliente);
    }
    //---------------------------------------------------------------
    //    Método para Eliminar el cliente 
    //---------------------------------------------------------------
    public void DeleteCliente(int idCliente)
    {
        var cliente = _context.Clientes!
        .FirstOrDefault(x => x.IdCliente == idCliente);
        _context.Clientes!.Remove(cliente!);
    }
    //---------------------------------------------------------------
    //    Método para obtener todos los clientes 
    //---------------------------------------------------------------
    public IEnumerable<Cliente> GetAllClientes()
    {
        return _context.Clientes!.ToList();
    }
    //---------------------------------------------------------------
    //    Método para obtener un cliente por su ID 
    //---------------------------------------------------------------
    public Cliente GetClienteById(int idCliente)
    {
        return _context.Clientes!.FirstOrDefault(x => x.IdCliente == idCliente)!;
    }

    //---------------------------------------------------------------
    //    Método para guardar el cliente
    //---------------------------------------------------------------
    public bool SaveChanges()
    {
        return (_context.SaveChanges() >= 0);
    }
}