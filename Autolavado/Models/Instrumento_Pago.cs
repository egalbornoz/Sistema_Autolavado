using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Instrumento_Pago
{
    [Key]
    [Required]
    public int IdInstrumento_Pago { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
}