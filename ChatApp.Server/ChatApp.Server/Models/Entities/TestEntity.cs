using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApp.Server.Models.Entities
{
    [Table("Test")]
    public class TestEntity
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
    
        [Column("Code")]
        public string Code { get; set; }
    
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}