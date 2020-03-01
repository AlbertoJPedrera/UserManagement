// -----------------------------------------------------
//     Class name
//     Author: Alberto José Pedrera Ros
//------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Core.Models;

namespace UserManagement.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();

        Task<User> GetById(Guid id);

        Task<User> Create(User newUser);

        Task Update(User userToBeUpdated, User user);

        Task Delete(User user);

        Task<User> GetByEmailAndPassword(string email, string password);

        Task<User> ApplyPatchAsync(User user, List<Patch> patches);
    }
}