using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Subfamilia
{
    [Key]
    [Required]
    public int IdSubfamilia { get; set; }
    public int IdFamilia { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
}