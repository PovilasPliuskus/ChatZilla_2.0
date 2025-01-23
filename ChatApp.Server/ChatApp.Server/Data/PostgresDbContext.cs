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
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<ChatParticipantsEntity> ChatParticipants { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEntity>(entity =>
            {
                entity.ToTable(tb => tb.HasComment("Table for testing purposes"));

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasComment("Guid ID");
                
                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasComment("Timestamp when the record was created");
            });

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.Property(id => id.Id)
                    .IsRequired();
                
                entity.Property(ca => ca.CreatedAt)
                    .IsRequired()
                    .HasComment("Timestamp when the record was created");

                entity.Property(ma => ma.ModifiedAt)
                    .HasComment("Timestamp when the record was modified");
            });

            modelBuilder.Entity<ChatEntity>(entity =>
            {
                entity.Property(id => id.Id)
                    .IsRequired();
                
                entity.Property(ca => ca.CreatedAt)
                    .IsRequired()
                    .HasComment("Timestamp when the record was created");

                entity.Property(ma => ma.ModifiedAt)
                    .HasComment("Timestamp when the record was modified");
            });

            modelBuilder.Entity<ChatParticipantsEntity>(entity =>
            {
                entity.Property(id => id.Id)
                    .IsRequired();
                
                entity.Property(ja => ja.JoinedAt)
                    .IsRequired()
                    .HasComment("Timestamp when the user joined the chat");
                
                entity.Property(ma => ma.ModifiedAt)
                    .HasComment("Timestamp when the record was modified");

                entity.HasOne(u => u.UserEntity)
                    .WithMany(u => u.ChatParticipants)
                    .HasForeignKey(fk => fk.UserId);

                entity.HasOne(c => c.ChatEntity)
                    .WithMany(c => c.ChatParticipants)
                    .HasForeignKey(fk => fk.ChatId);
            });

            modelBuilder.Entity<MessageEntity>(entity =>
            {
                entity.Property(id => id.Id)
                    .IsRequired();
                
                entity.Property(ca => ca.CreatedAt)
                    .IsRequired()
                    .HasComment("Timestamp when the record was created");
                
                entity.Property(ma => ma.ModifiedAt)
                    .HasComment("Timestamp when the record was modified");

                entity.HasOne(c => c.ChatEntity)
                    .WithMany(m => m.Messages)
                    .HasForeignKey(fk => fk.ChatId);
            });
        }
    }
}