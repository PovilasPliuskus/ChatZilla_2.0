using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApp.Server.Models.Entities
{
    [Table("ChatParticipants")]
    public class ChatParticipants
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        
        [Column("UserId")]
        public Guid UserId { get; set; }
        
        [Column("ChatId")]
        public Guid ChatId { get; set; }
        
        [Column("UserRole")]
        public int UserRole { get; set; }
        
        [Column("JoinedAt")]
        public DateTime JoinedAt { get; set; }
        
        [Column("IsLeft")]
        public byte IsLeft { get; set; }
        
        [Column("LeftAt")]
        public DateTime? LeftAt { get; set; }
        
        [Column("ModifiedAt")]
        public DateTime? ModifiedAt { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        
        [ForeignKey(nameof(ChatId))]
        public virtual Chat Chat { get; set; }
    }
}
