using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class Proveedor
{
    [Key]
    [Required]
    public int IdProveedor { get; set; }
    public int IdTipo_Documento { get; set; }
    public string? Numero_Documento { get; set; }
    public string? Nombre { get; set; }
    public string? Direccion_Fiscal { get; set; }
    public string? Telefono { get; set; }
    public string? Movil { get; set; }
    public string? Email { get; set; }
    public DateTime? Fecha_Creacion { get; set; }
    public DateTime? Fecha_Modificacion { get; set; }
    public bool Estado { get; set; }
}