using Microsoft.EntityFrameworkCore;
using StoryDb3.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb3.Model.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string connectionString) 
        {
            _connectionString = connectionString;
        }

        public bool CreateDatabase()
        {
            try
            {
                // Создаем контекст с заданным connection string
                var optionsBuilder = new DbContextOptionsBuilder<StoryDbContext>();
                optionsBuilder.UseSqlite(_connectionString);

                using (var context = new StoryDbContext(optionsBuilder.Options))
                {
                    // Создаем БД если она не существует
                    context.Database.EnsureCreated();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании БД: {ex.Message}");
                return false;
            }
        }
    }
}
