using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApp.Server.Models.Entities
{
    [Table("User")]
    public class UserEntity
    {
        public UserEntity()
        {
            ChatParticipants = new HashSet<ChatParticipantsEntity>();
        }
        
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        
        [Required]
        [Column("Username")]
        [StringLength(255)]
        public string Username { get; set; }
        
        [Required]
        [Column("Email")]
        [StringLength(255)]
        public string Email { get; set; }
        
        [Required]
        [Column("PasswordHash")]
        [StringLength(255)]
        public string PasswordHash { get; set; }
        
        [Required]
        [Column("Code")]
        [StringLength(255)]
        public string Code { get; set; }
        
        [Required]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        
        [Column("ModifiedAt")]
        public DateTime? ModifiedAt { get; set; }
        
        [Column("LastLogin")]
        public DateTime? LastLogin { get; set; }
        
        public virtual ICollection<ChatParticipantsEntity> ChatParticipants { get; set; }
    }
}