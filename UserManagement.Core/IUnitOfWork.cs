using System;
using System.Threading.Tasks;
using UserManagement.Core.Repositories;

namespace UserManagement.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        
        Task<int> CommitAsync();
    }
}