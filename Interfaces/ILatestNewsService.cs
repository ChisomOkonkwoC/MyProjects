using Ecommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Contracts
{
    public interface ILatestNewsService
    {
        Task <List<News>> GetAllLatestNews();
    }
}
