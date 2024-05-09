using Autolavado.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Autolavado.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
//Se agregan todo los dbset de las tablas que se van a crear automaticamente
    public DbSet<Banco>? Bancos { get; set; }
    public DbSet<Cliente>? Clientes { get; set; }
    public DbSet<Compra>? Compras { get; set; }
    public DbSet<Cuenta_Pagar>? Cuentas_Pagar { get; set; }
    public DbSet<Cuenta>? Cuentas { get; set; }
    public DbSet<DetCompra>? DetCompras { get; set; }
    public DbSet<DetCuenta_Cobrar>? DetCuentas_Cobrar { get; set; }
    public DbSet<DetCuenta_Pagar>? DetCuentas_Pagar { get; set; }
    public DbSet<DetVenta>? DetVentas { get; set; }
    public DbSet<Familia>? Familias { get; set; }
    public DbSet<Forma_Pago>? Formas_Pagos { get; set; }
    public DbSet<Instrumento_Pago>? Instrumentos_Pagos { get; set; }
    public DbSet<Marca>? Marcas { get; set; }
    public DbSet<Producto>? Productos { get; set; }
    public DbSet<Proveedor>? Proveedores { get; set; }
    public DbSet<Servicio>? Servicios { get; set; }
    public DbSet<Subfamilia>? Subfamilias { get; set; }
    public DbSet<Tipo_Documento>? Tipos_Documentos { get; set; }
    public DbSet<Unidad_Medida>? Unidades_Medidas { get; set; }
    public DbSet<Venta>? Ventas { get; set; }
}