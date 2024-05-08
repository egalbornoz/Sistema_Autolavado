using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class Cuenta
{
    [Key]
    [Required]
    public int IdCuenta { get; set; }

    public int IdBanco { get; set; }

    public string? Numero_Cuenta { get; set; }
    
    [Required]
    [Column(TypeName ="decimal(14,2)")]
    public decimal saldo { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public bool Estado { get; set; }
}