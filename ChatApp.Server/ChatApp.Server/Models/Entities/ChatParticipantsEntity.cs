using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApp.Server.Models.Entities
{
    [Table("ChatParticipants")]
    public class ChatParticipantsEntity
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        
        [Required]
        [Column("UserId")]
        public Guid UserId { get; set; }
        
        [Required]
        [Column("ChatId")]
        public Guid ChatId { get; set; }
        
        [Required]
        [Column("UserRole")]
        public int UserRole { get; set; }
        
        [Required]
        [Column("JoinedAt")]
        public DateTime JoinedAt { get; set; }
        
        [Required]
        [Column("IsLeft")]
        public byte IsLeft { get; set; }
        
        [Column("LeftAt")]
        public DateTime? LeftAt { get; set; }
        
        [Column("ModifiedAt")]
        public DateTime? ModifiedAt { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual UserEntity UserEntity { get; set; }
        
        [ForeignKey(nameof(ChatId))]
        public virtual ChatEntity ChatEntity { get; set; }
    }
}
