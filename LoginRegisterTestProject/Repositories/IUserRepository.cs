using LoginRegisterTestProject.Entities;

namespace LoginRegisterTestProject.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> Get();
        Task<User> Get(int userId);
        Task<User> Add(User user);
        Task<bool> Check(User user);
        Task<User> Update(User user);
        Task Delete(int userId);
    }
}
