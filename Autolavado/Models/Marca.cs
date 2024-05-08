using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Marca
{
    [Key]
    [Required]
    public int IdMarca { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
}