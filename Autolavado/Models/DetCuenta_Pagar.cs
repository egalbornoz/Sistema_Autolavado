using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class DetCuenta_Pagar
{
    [Key]
    [Required]
    public int IdDetCuenta_Pagar { get; set; }
    public int IdCuenta_Pagar { get; set; }
    public int IdInstrumento_Pago { get; set; }
    public int IdForma_Pago { get; set; }
    public int IdBanco { get; set; }

    public string? Concepto { get; set; }
    public string? Referencia { get; set; }
    [Required]
    [Column(TypeName = "decimal(14,2)")]
    public decimal Monto_Pago { get; set; }
    public DateTime? Fecha_Pago { get; set; }
}