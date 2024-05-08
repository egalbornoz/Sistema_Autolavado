using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Forma_Pago
{
    [Key]
    [Required]
    public int IdForma_Pago { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
}