using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class Cuenta_Cobrar
{
    [Key]
    [Required]
    public int IdCuenta_Cobrar { get; set; }
    public int IdCliente { get; set; }
    public int IdVenta { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Saldo_Factura { get; set; }
    public DateTime? Fecha_Creacion { get; set; }
    public DateTime? Fecha_Vencimiento { get; set; }
    public bool Estado { get; set; }
}