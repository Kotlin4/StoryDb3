using StoryDb3.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb3.Model.Entities
{
    public class Character : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;

        // Связь многие-ко-многим с Archetype
        public ICollection<Archetype> Archetypes { get; set; } = new List<Archetype>();
    }
}
