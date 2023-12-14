using System.ComponentModel.DataAnnotations.Schema;

namespace UserManager.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime CreateAt { get; set; } =DateTime.Now;
        public DateTime UpdateAt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int UserStatusId { get; set; }
        [ForeignKey(nameof(UserStatusId))]
        public UserStatus UserStatus { get; set; }
        public int RoleId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
        public int TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; }

        public bool IsActive { get; set; } = false;
        public List<ConfirmEmails> ConfirmEmailsList { get; set; }
        public List<Notifications> NotificationsList { get; set; }
    }
}
