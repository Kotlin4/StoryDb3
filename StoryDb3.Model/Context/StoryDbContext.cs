using Microsoft.EntityFrameworkCore;
using StoryDb3.Model.Configuration.Relationships;
using StoryDb3.Model.Entities;
using StoryDb3.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb3.Model.Context
{
    public class StoryDbContext : DbContext
    {

        public StoryDbContext(DbContextOptions<StoryDbContext> options) : base(options)
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Автоматическое применение всех конфигураций из сборки
            var configurationAssembly = Assembly.GetExecutingAssembly();

            foreach (var type in configurationAssembly.GetTypes())
            {
                if(typeof(IEntityTypeConfiguration<>).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    dynamic configurationInstance = Activator.CreateInstance(type);
                    modelBuilder.ApplyConfiguration(configurationInstance);
                }
            }

            // Автоматическое добавление всех сущностей, реализующих IModelTable
            var modelTableTypes = configurationAssembly.GetTypes()
                .Where(t => typeof(IModelTable).IsAssignableFrom(t) && !t.IsAbstract);

            foreach (var type in modelTableTypes)
            {
                modelBuilder.Entity(type);
            }

        }
    }
}
