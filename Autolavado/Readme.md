# PROCEDIMIENTO PARA CREAR Y CONFIGURAR UN PROYECTO WEB API EN ASP.NET

1.-  En la linea de comando escribir

    * dotnet new webapi --name NOMBE_PROYECTO

2.-  Ingresar al directorio y agregar paquetes 

    * dotnet add package AutoMapper
    * dotnet add package Microsoft.EntityFrameworkCore   
    * dotnet add package Microsoft.EntityFrameworkCore.Design
    * dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    * dotnet add package Newtonsoft.Json
    * dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
    * dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
    * dotnet add package System.IdentityModel.Tokens.Jwt

3.- En Program.cs

   Agregar

builder.Services.AddMvc();
     app.UseAuthentication();
     app.UseAuthorization();

  Comentar.
 // app.UseHttpsRedirection();

4.- Dentro del Directorio raiz Properties
  
  abrir el archivo  launchSettings.json

Eliminar de Profiles:
"https": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:7174;http://localhost:5147",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },

5.- Ejecutar la app para verificar que esta levantando

  dotnet run


6.- Configurar EntityFramework
   * Crear directorio Data
   * Agregar dentro una clase llamada AppDbContext.cs
   
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

7.- En la carpera data Crear una Clase para Insertar datos de prueba

* Crear la Clase LoadDatabase para cargar data inicial
using System.ComponentModel;
using System.Globalization;
using Autolavado.Models;
using Microsoft.AspNetCore.Identity;

namespace Autolavado.Data;

public class LoadDataBase
{
    public static async Task InsertarData(AppDbContext context, UserManager<Usuario> usuarioManager)
    {
        if (usuarioManager.Users.Any())
        {
            var usuario = new Usuario
            {
                Nombre = "Edwin",
                Apellido = "Albornoz",
                Email = "egalbornoz@gmail.com",
                UserName = "egalbornoz",
                Telefono = "0424-9115617"
            };

            await usuarioManager.CreateAsync(usuario, "Maria2709**");
        }
        //Aqui se agregan toda la creación automática de los catalogos con la data inicial 
        //Tabla de Bancos Bancos
        if (!context.Bancos!.Any())
        {
            context.Bancos!.AddRange(
             new Banco
             {
                 Codigo_Banco = "0001",
                 Descripcion = "Banco Central de Venezuela",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0102",
                 Descripcion = "Banco de Venezuela, S.A. Banco Universal",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0104",
                 Descripcion = "Banco Venezolano de Crédito, S.A",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0105",
                 Descripcion = "Banco Mercantil C.A.",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0108",
                 Descripcion = "Banco Provincial, S.A",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0114",
                 Descripcion = "Banco del Caribe C.A",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0115",
                 Descripcion = "Banco Exterior C.A.",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0128",
                 Descripcion = "Banco Caroní C.A.",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0134",
                 Descripcion = "Banesco Banco Universal, C.A.",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0137",
                 Descripcion = "Banco Sofitasa Banco Universal, C.A .",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0138",
                 Descripcion = "Banco Plaza, Banco universal",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0146",
                 Descripcion = "Banco de la Gente Emprendedora C.A.",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0151",
                 Descripcion = "Banco Fondo Común, C.A Banco Universal",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0156",
                 Descripcion = "100% Banco, Banco Comercial, C.A",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0157",
                 Descripcion = "DelSur, Banco Universal C.A.",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0163",
                 Descripcion = "Banco del Tesoro C.A., Banco Universal",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0166",
                 Descripcion = "Banco Agrícola de Venezuela C.A., Banco Universal",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0168",
                 Descripcion = "Bancrecer S.A., Banco Microfinanciero",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0169",
                 Descripcion = "Mi Banco, Banco Microfinanciero, C.A.",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0171",
                 Descripcion = "Banco Activo C.A., Banco Universal",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0172",
                 Descripcion = "Bancamiga Banco Universal, C.A.",
                 Estado = true
             },
             new Banco
             {
                Codigo_Banco = "0173",
                Descripcion = "Banco Internacional de Desarrollo C.A., Banco Universal",
                Estado = true
             },
             new Banco
             {
                Codigo_Banco = "0174",
                Descripcion = "Banplus Banco Universal, C.A",
                Estado = true
             },
             new Banco
             {
                Codigo_Banco = "0175",
                Descripcion = "Banco Bicentenario del Pueblo, Banco Universal C.A",
                Estado = true
             }             
             
            );
        }
        //Graba los cambios el la db.
        context.SaveChanges();
    }
}

8.- Implementar Token de Seguridad

Crear carpeta Token
Agregar class JwtGenerator.cs

//Un Claim es un objeto de tipo Diccionario
// Crear Interfaces IJwtGenerator
// Crear Clase JwtGenerator

9.-Agregar En la carpeta Token 
Interface IUsuarioSesion.cs
Clase      UsuarioSesion.cs 

10. Agregar el Repositorio Entidad
En la Carpeta Data Agregar el directorio Compra, ventas etc de acuerdo a cada 
Clase entidad

11. Implementar lia Interfaces y Repositorios
12. Crear e Implementar los DTOS
13. Middleware