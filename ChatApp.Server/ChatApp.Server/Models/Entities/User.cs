using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApp.Server.Models.Entities
{
    [Table("User")]
    public class User
    {
        public User()
        {
            ChatParticipants = new HashSet<ChatParticipants>();
        }
        
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        
        [Column("Username")]
        [StringLength(255)]
        public string Username { get; set; }
        
        [Column("Email")]
        [StringLength(255)]
        public string Email { get; set; }
        
        [Column("PasswordHash")]
        [StringLength(255)]
        public string PasswordHash { get; set; }
        
        [Column("Code")]
        [StringLength(255)]
        public string Code { get; set; }
        
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        
        [Column("ModifiedAt")]
        public DateTime? ModifiedAt { get; set; }
        
        [Column("LastLogin")]
        public DateTime? LastLogin { get; set; }
        
        public virtual ICollection<ChatParticipants> ChatParticipants { get; set; }
    }
}