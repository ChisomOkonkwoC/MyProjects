using Ecommerce.Contracts;
using Ecommerce.EcommerceRepository;
using Ecommerce.Models;
using Ecommerce.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class UserService : IUserService
    {
        private readonly ICommandRepo<User> _commandRepo;

        public UserService(ICommandRepo<User> commandRepo)
        {
            _commandRepo = commandRepo;
        }
        private static List<User> userFile = new List<User>();
        public async Task<bool> AddUser(User model)
        {
            try
            {
               await _commandRepo.Insert(model);
               return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                List<User> users = await _commandRepo.GetRecord();
                return users;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
