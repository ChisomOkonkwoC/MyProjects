using Ecommerce.Contracts;
using Ecommerce.EcommerceRepository;
using Ecommerce.Models;
using Ecommerce.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class LatestNewsService : ILatestNewsService
    {

        private readonly ICommandRepo<News> _commandRepo;

        public LatestNewsService(ICommandRepo<News> commandRepo)
        {
            _commandRepo = commandRepo;
        }
        public async Task<List<News>> GetAllLatestNews()
        {
            try
            {
                List<News> latestNews = await _commandRepo.GetRecord();
                return latestNews;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
