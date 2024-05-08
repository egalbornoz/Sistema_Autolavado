using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Familia
{
    [Key]
    [Required]
    public int IdFamilia { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
}