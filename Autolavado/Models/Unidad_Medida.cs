using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Unidad_Medida
{
    [Key]
    [Required]
    public int IdUnidad_Medida { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
}