using System.ComponentModel.DataAnnotations;

namespace UserManager.Entity
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
    }
}
