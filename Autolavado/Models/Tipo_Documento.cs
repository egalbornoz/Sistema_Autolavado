using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Tipo_Documento
{
    [Key]
    [Required]
    public int IdTipo_Documento { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
}