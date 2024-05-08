using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class DetCompra
{
    [Key]
    [Required]
    public int IdDetCompra { get; set; }
    public int IdCompra { get; set; }
    public int IdProducto { get; set; }
    public int IdServicio { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Cantidad { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Precio_Unitario { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Total { get; set; }
    public DateTime? Fecha_Creacion { get; set; }
    public DateTime? Fecha_Modificacion { get; set; }
    public bool Estado { get; set; }
}