using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApp.Server.Models.Entities
{
    [Table("Message")]
    public class Message
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        
        [Column("ChatId")]
        public Guid ChatId { get; set; }
        
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        
        [Column("ModifiedAt")]
        public DateTime? ModifiedAt { get; set; }
        
        [ForeignKey(nameof(ChatId))]
        public virtual Chat Chat { get; set; }
    }
}