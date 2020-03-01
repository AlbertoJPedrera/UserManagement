using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.Core.Repositories;
using UserManagement.Data.Repositories;

namespace UserManagement.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserManagementDbContext _context;

        private UserRepository _userRepository;

        public UnitOfWork(UserManagementDbContext context)
        {
            this._context = context;
        }

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}