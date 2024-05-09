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
             },
             new Banco
             {
                 Codigo_Banco = "0177",
                 Descripcion = "Banco de la Fuerza Armada Nacional Bolivariana, B.U.",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0178",
                 Descripcion = "N58 Banco Digital, Banco Microfinanciero",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0191",
                 Descripcion = "Banco Nacional de Crédito C.A., Banco Universal",
                 Estado = true
             },
             new Banco
             {
                 Codigo_Banco = "0601",
                 Descripcion = " Instituto Municipal de Crédito Popular",
                 Estado = true
             }
            );
        }
        //Graba los cambios el la db.
        context.SaveChanges();
    }
}