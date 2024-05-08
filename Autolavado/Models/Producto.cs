using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autolavado.Models;

public class Producto
{
    [Key]
    [Required]
    public int IdProducto { get; set; }
    public string? Descripcion { get; set; }
    public int IdMarca { get; set; }
    public int IdUnidad_Medida { get; set; }
    public int IdSubfamilia { get; set; }
     [Required]
    [Column(TypeName ="decimal(14,2)")]
    public decimal Precio_Unitario { get; set; }
    public DateTime? Fecha_Creacion { get; set; }
    public DateTime? Fecha_Modificacion { get; set; }
    public bool Estado { get; set; }
}