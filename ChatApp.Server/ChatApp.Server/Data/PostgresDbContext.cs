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

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(id => id.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("gen_random_uuid()");
                
                entity.Property(ca => ca.CreatedAt)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Timestamp when the record was created");

                entity.Property(ma => ma.ModifiedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnUpdate()
                    .HasComment("Timestamp when the record was modified");
            });

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.Property(id => id.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("gen_random_uuid()");
                
                entity.Property(ca => ca.CreatedAt)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Timestamp when the record was created");

                entity.Property(ma => ma.ModifiedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnUpdate()
                    .HasComment("Timestamp when the record was modified");
            });

            modelBuilder.Entity<ChatParticipants>(entity =>
            {
                entity.Property(id => id.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("gen_random_uuid()");
                
                entity.Property(ja => ja.JoinedAt)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Timestamp when the user joined the chat");
                
                entity.Property(ma => ma.ModifiedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnUpdate()
                    .HasComment("Timestamp when the record was modified");

                entity.HasOne(u => u.User)
                    .WithMany(u => u.ChatParticipants)
                    .HasForeignKey(fk => fk.UserId);

                entity.HasOne(c => c.Chat)
                    .WithMany(c => c.ChatParticipants)
                    .HasForeignKey(fk => fk.ChatId);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(id => id.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("gen_random_uuid()");
                
                entity.Property(ca => ca.CreatedAt)
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Timestamp when the record was created");
                
                entity.Property(ma => ma.ModifiedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnUpdate()
                    .HasComment("Timestamp when the record was modified");

                entity.HasOne(c => c.Chat)
                    .WithMany(m => m.Messages)
                    .HasForeignKey(fk => fk.ChatId);
            });
        }
    }
}