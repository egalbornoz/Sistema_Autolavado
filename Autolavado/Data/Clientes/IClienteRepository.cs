using Autolavado.Models;

namespace Autolavado.Data.Clientes;

public interface IClienteRepository
{
    bool SaveChanges();
    IEnumerable<Cliente> GetAllClientes();
    Cliente GetClienteById(int idCliente);
    Task CreateClienteAsync(Cliente cliente);
    void DeleteCliente(int idCliente);
}