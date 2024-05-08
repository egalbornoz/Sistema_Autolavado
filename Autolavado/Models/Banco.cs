using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Banco
{

    [Key]
    [Required]
    public int IdBanco { get; set; }
    public string? Codigo_Banco { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }

}