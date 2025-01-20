using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApp.Server.Models.Entities
{
    [Table("Chat")]
    public class Chat
    {
        public Chat()
        {
            ChatParticipants = new HashSet<ChatParticipants>();
            Messages = new HashSet<Message>();
        }
        
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        
        [Column("Name")]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Column("Type")]
        public int Type { get; set; }
        
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        
        [Column("ModifiedAt")]
        public DateTime? ModifiedAt { get; set; }
        
        public virtual ICollection<ChatParticipants> ChatParticipants { get; set; }
        
        public virtual ICollection<Message> Messages { get; set; }
    }
}