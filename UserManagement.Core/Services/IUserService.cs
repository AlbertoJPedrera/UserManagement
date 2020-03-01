using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Core.Models;

namespace UserManagement.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();

        Task<User> GetById(int id);

        Task<User> Create(User newUser);

        Task Update(User userToBeUpdated, User user);

        Task Delete(User user);

        Task<User> GetByEmailAndPassword(string email, string password);
    }
}