using ChatApp.Server.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Server.Data
{
    public class PostgresDbContext : DbContext
    {
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
        {
        }
        
        public DbSet<TestEntity> TestEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEntity>(entity =>
            {
                entity.ToTable(tb => tb.HasComment("Table for testing purposes"));

                entity.Property(e => e.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("gen_random_uuid()")
                    .HasComment("Guid ID");
                
                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Timestamp when the record was created");
            });
        }
    }
}