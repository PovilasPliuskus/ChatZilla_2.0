using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatZilla.API.Models.Entities
{
    [Table("Message")]
    public class MessageEntity
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        
        [Required]
        [Column("ChatId")]
        public Guid ChatId { get; set; }
        
        [Required]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        
        [Column("ModifiedAt")]
        public DateTime? ModifiedAt { get; set; }
        
        [ForeignKey(nameof(ChatId))]
        public virtual ChatEntity ChatEntity { get; set; }
    }
}