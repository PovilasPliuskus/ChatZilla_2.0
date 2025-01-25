using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ChatZilla.API.Models.Entities
{
    [Table("Chat")]
    public class ChatEntity
    {
        public ChatEntity()
        {
            ChatParticipants = new HashSet<ChatParticipantsEntity>();
            Messages = new HashSet<MessageEntity>();
        }
        
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        
        [Required]
        [Column("Name")]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        [Column("Type")]
        public int Type { get; set; }
        
        [Required]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        
        [Column("ModifiedAt")]
        public DateTime? ModifiedAt { get; set; }
        
        public virtual ICollection<ChatParticipantsEntity> ChatParticipants { get; set; }
        
        public virtual ICollection<MessageEntity> Messages { get; set; }
    }
}