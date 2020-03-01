using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Core.Models;

namespace UserManagement.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAndPasswordAsync(string email, string password);

        Task<User> UpdatePassword(User user, string password);
    }
}