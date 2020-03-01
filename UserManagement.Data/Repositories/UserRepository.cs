using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserManagement.Core.Models;
using UserManagement.Core.Repositories;

namespace UserManagement.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UserManagementDbContext context) 
            : base(context)
        { }

        public async Task<User> GetByEmailAndPasswordAsync(string email, string password)
        {
            return await UserManagementDbContext.Users
                .SingleOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public User UpdatePassword(User user, string password)
        {
            user.Password = password;

            return UserManagementDbContext.Users
                .Update(user);
        }

        private UserManagementDbContext UserManagementDbContext
        {
            get { return Context as UserManagementDbContext; }
        }
    }
}