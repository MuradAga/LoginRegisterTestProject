using LoginRegisterTestProject.Models;

namespace LoginRegisterTestProject.Services
{
    public interface IUserService
    {
        Task<UserToListDTO> Add(UserToAddDTO user);
        Task<bool> Check(UserLoginDTO user);
        Task<UserToListDTO> Get(int id);
    }
}
