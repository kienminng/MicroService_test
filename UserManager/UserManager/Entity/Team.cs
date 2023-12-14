using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManager.Entity
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int Member { get; set; }
        public string Description { get; set; }
        public string Sologan { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int TruongPhongId { get; set; }
        [ForeignKey(nameof(TruongPhongId))]
        public User TruongPhong { get; set; }
        public int TeamStatusId { get; set; }
        [ForeignKey(nameof(TeamStatusId))]
        public TeamStatus Status { get; set; }
        public List<User> Users { get; set; }
    }
}
