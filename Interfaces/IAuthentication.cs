using Ecommerce.Models;
using System.Threading.Tasks;

namespace Ecommerce.Contracts
{
    public interface IAuthentication
    {
        Task<User> Login(string username, string password); 
    }
}
