// -----------------------------------------------------
//     Class name
//     Author: Alberto Jos� Pedrera Ros
//------------------------------------------------------

using System.Threading.Tasks;
using UserManagement.Core.Models;

namespace UserManagement.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAndPasswordAsync(string email, string password);
    }
}