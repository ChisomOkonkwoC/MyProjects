using Ecommerce.Infastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ecommerce.EcommerceRepository
{
    public class CommandRepo<T> : ICommandRepo<T> where T : class
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        private readonly ILogger<T> _logger;

        public CommandRepo(AppDbContext dbContext, DbSet<T> dbSet/*, ILogger<T> logger*/)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
           
        }

        public bool Delete(T entity)
        {
            _logger.LogInformation($"About to delete { typeof(T).FullName} in method {nameof(Delete)}");
            try
            {
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    _dbContext.SaveChanges();
                }
                _logger.LogInformation($"completed delete operation in method {nameof(Delete)}");
                return true;
            }
            catch(Exception ex)
            {
                _logger.LogInformation($"errMessage: { ex.Message},errStacktrace: { ex.StackTrace}", ex);
                //Console.WriteLine($"{ex.StackTrace},{ex.StackTrace},{ex.Message}", ex);
                throw;

            }

        }

        public async Task<List<T>> GetRecord()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<bool> Insert(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                throw;
            }
            
        }
    }
}
