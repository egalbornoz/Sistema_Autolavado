using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class Cliente
{
    [Key]
    [Required]
    public int IdCliente { get; set; }
    public int IdTipo_Documento { get; set; }
    public string? Numero_Documento { get; set; }
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }
    public string? Movil { get; set; }
    public string? Email { get; set; }
    public DateTime? Fecha_Creacion { get; set; }
    public DateTime? Fecha_Modificacion { get; set; }
    public bool Estado { get; set; }
    //Se agrega un campo id para relacionar el usuario con  la compra
    public Guid? UsuarioId { get; set; }
}