using System.ComponentModel.DataAnnotations;

namespace ProductManager.Entity;

public class ProductStatus
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Code { get; set; }
    public List<Product> Products { get; set; }
}