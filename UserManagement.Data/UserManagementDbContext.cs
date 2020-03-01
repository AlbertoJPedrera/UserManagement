using Microsoft.EntityFrameworkCore;
using UserManagement.Core.Models;

namespace UserManagement.Data
{
    public class UserManagementDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options)
            : base(options)
        { }
    }
}