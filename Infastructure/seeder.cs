using Ecommerce.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Infastructure
{
    public class seeder
    {
        public static async Task SeedData(AppDbContext dbContext)
        {
            var baseDir = Directory.GetCurrentDirectory();

            await dbContext.Database.EnsureCreatedAsync();

            if (!dbContext.Users.Any())
            {

                var path = File.ReadAllText(FilePath(baseDir, "Json/ser.json"));

                List<User> users = JsonConvert.DeserializeObject<List<User>>(path);
                await dbContext.Users.AddRangeAsync(users);
                await dbContext.SaveChangesAsync();
            }
           if (!dbContext.Categories .Any())
            {
                var path = File.ReadAllText(FilePath(baseDir, "Json/Category.json"));
                var category = JsonConvert.DeserializeObject<List<Category>>(path);
                await dbContext.Categories.AddRangeAsync(category);
                await dbContext.SaveChangesAsync();
            }
            if (!dbContext.Products.Any())
            {
                var path = File.ReadAllText(FilePath(baseDir, "Json/Product.json"));
                var products = JsonConvert.DeserializeObject<List<Product>>(path);
                await dbContext.Products.AddRangeAsync(products);
            }
            if (!dbContext.News.Any())
            {
                var path = File.ReadAllText(FilePath(baseDir, "Json/LatestNews.json"));
                var latestNews = JsonConvert.DeserializeObject<List<News>>(path);
                await dbContext.News.AddRangeAsync(latestNews);
            }
           

            await dbContext.SaveChangesAsync();
        }


        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }
    }
}
