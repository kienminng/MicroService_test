using System.ComponentModel.DataAnnotations;

namespace VideoManager.Entity;

public class VideoBaiHocStatus
{
    [Key]
    public int Id { get; set; }
    public string Code { get; set; }
    [Required]
    public string Name { get; set; }
}