using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApi.Models;

/// <summary>
/// Entidad que representa un producto en el sistema.
/// Cada producto tiene un ID único, nombre, descripción, precio y fecha de creación.
/// </summary>
public class Product
{
    /// <summary>
    /// Identificador único del producto (clave primaria autoincremental)
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Nombre del producto (requerido, máximo 255 caracteres)
    /// </summary>
    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Descripción detallada del producto
    /// </summary>
    [MaxLength(1000)]
    public string? Description { get; set; }

    /// <summary>
    /// Precio del producto (debe ser positivo)
    /// </summary>
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a cero")]
    public decimal Price { get; set; }

    /// <summary>
    /// Fecha y hora de creación del registro
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}