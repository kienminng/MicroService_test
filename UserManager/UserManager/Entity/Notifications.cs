using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManager.Entity;

public class Notifications
{
    [Key]
    public int Id { get; set; }
    public int CreateId { get; set; }
    [ForeignKey(nameof(CreateId))]
    public User User { get; set; }
    public DateTime CreateAt { get; set; }
    public string Content { get; set; }
    public string Title { get; set; }
    public int StatusId { get; set; }
    [ForeignKey(nameof(StatusId))]
    public NotificationStatuses NotificationStatuses { get; set; }
}