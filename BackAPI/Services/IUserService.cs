using BackAPI.Entity;
using BackAPI.Models;

namespace BackAPI.Services
{
    public interface IUserService
    {
        Task<bool> AddUsers(UserModel user);
        Task<bool> RemoveUsers();
        Task<List<User>> GetAllUsers();
    }
}

