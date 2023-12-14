using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManager.Entity;

public class ConfirmEmails
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }
    public DateTime RequiredDateTime { get; set; }
    public DateTime ExpiredDateTime { get; set; }
    public string Code { get; set; }
    public bool IsConfirm { get; set; }
}