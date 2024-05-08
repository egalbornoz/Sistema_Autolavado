using System.Net.Mime;
using System.ComponentModel.DataAnnotations;

namespace Autolavado.Models;

public class Imagen_Producto
{
    public int IdProducto { get; set; }
    public string? Imagen { get; set; }
    public bool Estado { get; set; }
}