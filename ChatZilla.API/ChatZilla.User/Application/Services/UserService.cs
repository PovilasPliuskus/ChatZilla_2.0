namespace ChatZilla.User.Application.Services
{
    public interface IUserService
    {
        public Task GetUserAsync(Guid userId);
    }
    
    internal class UserService : IUserService
    {
        public Task GetUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}

