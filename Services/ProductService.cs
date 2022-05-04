using Ecommerce.Contracts;
using Ecommerce.EcommerceRepository;
using Ecommerce.Models;
using Ecommerce.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly ICommandRepo<Product> _commandRepo;

        public ProductService(ICommandRepo<Product> commandRepo)
        {
            _commandRepo = commandRepo;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                List<Product> products = await _commandRepo.GetRecord();
                return products;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> GetProductById(int id)
        {
            try
            {
                var products = await _commandRepo.GetRecord();
                if(products != null)
                {
                    var product = products.FirstOrDefault(x => x.Id == id);
                    return product;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
