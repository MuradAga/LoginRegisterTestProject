using LoginRegisterTestProject.Entities;
using LoginRegisterTestProject.Models;
using LoginRegisterTestProject.Repositories;

namespace LoginRegisterTestProject.Services
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserToListDTO> Add(UserToAddDTO user)
        {
            User addUser = new User()
            {
                UserName = user.UserName,
                Name = user.Name,
                Surname = user.Surname,
                Password = user.Password
            };
            User addedUser = await _userRepository.Add(addUser);
            UserToListDTO userToListDTO = new UserToListDTO()
            {
                UserId = addUser.UserId,
                UserName = addUser.UserName,
                Name = addUser.Name,
                Surname = addUser.Surname
            };
            return userToListDTO;
        }

        public async Task<bool> Check(UserLoginDTO user)
        {
            User user1 = new User()
            {
                UserName = user.UserName,
                Password = user.Password
            };
            return await _userRepository.Check(user1);
        }

        public async Task<UserToListDTO> Get(int id)
        {
            User user = await _userRepository.Get(id);
            UserToListDTO userToListDTO = new UserToListDTO()
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Name = user.Name,
                Surname = user.Surname
            };
            return userToListDTO;
        }
    }
}
