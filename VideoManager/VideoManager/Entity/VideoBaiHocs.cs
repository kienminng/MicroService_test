using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoManager.Entity;

public class VideoBaiHocs
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int CreatorId { get; set; }
    [Required]
    public string UrlPath { get; set; }
    public DateTime CreateAt { get; set; }
    public string Name { get; set; }
    public int StatusId { get; set; }
    [ForeignKey(nameof(StatusId))]
    public VideoBaiHocStatus Status { get; set; }
}