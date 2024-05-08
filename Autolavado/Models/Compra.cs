using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class Compra
{
    [Key]
    [Required]
    public int IdCompra { get; set; }
    public int IdProveedor { get; set; }
    public string? Numero_Factura { get; set; }
    public string? Numero_Control { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Subtotal { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Monto_Factura { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Monto_Impuesto { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Exento { get; set; }
    public DateTime? Fecha_Creacion { get; set; }
    public DateTime? Fecha_Modificacion { get; set; }
    public bool Estado { get; set; }
}