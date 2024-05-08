using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class Cuenta_Pagar
{
    [Key]
    [Required]
    public int IdCuenta_Pagar { get; set; }
    public int IdProveedor { get; set; }
    public int IdCompra { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Saldo_Factura { get; set; }
    public DateTime? Fecha_Creacion { get; set; }
    public DateTime? Fecha_Vencimiento { get; set; }
    public bool Estado { get; set; }
}