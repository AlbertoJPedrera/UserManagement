using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.Core.Models;
using UserManagement.Core.Services;

namespace UserManagement.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User> Create(User newUser)
        {
            await _unitOfWork.Users.AddAsync(newUser);

            await _unitOfWork.CommitAsync();

            return newUser;
        }

        public async Task Delete(User user)
        {
            _unitOfWork.Users.Remove(user);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _unitOfWork.Users
                .GetAllAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _unitOfWork.Users
                .GetByIdAsync(id);
        }

        public async Task<User> GetByEmailAndPassword (string email, string password)
        {
            return await _unitOfWork.Users
                .GetByEmailAndPasswordAsync(email, password);
        }

        public async Task Update(User userToBeUpdated, User user)
        {
            userToBeUpdated.Name = user.Name;
            userToBeUpdated.LastName = user.LastName;
            userToBeUpdated.Country = user.Country;
            userToBeUpdated.Email = user.Email;
            userToBeUpdated.Password = user.Password;
            userToBeUpdated.PhoneNumber = user.PhoneNumber;
            userToBeUpdated.PostalCode = user.PostalCode;

            await _unitOfWork.CommitAsync();
        }

        public async Task<User> UpdatePassword(User user, string newPassword)
        {
            user.Password = newPassword;

            await _unitOfWork.CommitAsync();

            return await _unitOfWork.Users
                .GetByIdAsync(user.Id);
        }
    }
}
