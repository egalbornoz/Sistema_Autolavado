using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class Servicio
{
    [Key]
    [Required]
    public int IdServicio { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }