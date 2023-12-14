using System.ComponentModel.DataAnnotations;

namespace UserManager.Entity
{
    public class UserStatus
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
    }
}
