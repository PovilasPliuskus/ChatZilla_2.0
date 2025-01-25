using ChatZilla.User.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatZilla.User.Infrastructure.Persistence
{
    // To add and apply migrations:
    // 1. Navigate to the directory where the ChatZilla.User project is located.
    // 2. Run the following command to add a migration:
    // dotnet ef migrations add UserTable --project ../ChatZilla.User/ChatZilla.User.csproj --startup-project ../ChatZilla.API/ChatZilla.API.csproj --context UserDbContext -o ../ChatZilla.User/Infrastructure/Persistence/Migrations
    // 3. Apply the migration to the database using:
    // dotnet ef database update --project ../ChatZilla.User/ChatZilla.User.csproj --startup-project ../ChatZilla.API/ChatZilla.API.csproj --context UserDbContext
    
    internal sealed class UserDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }
    }
    
}