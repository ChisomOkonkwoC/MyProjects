using Ecommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Contracts
{
    public interface IUserService
    {
        Task<bool> AddUser(User model);
        Task<List<User>> GetAllUsers();


    }
}
