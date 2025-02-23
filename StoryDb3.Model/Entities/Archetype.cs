using StoryDb3.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb3.Model.Entities
{
    public class Archetype : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public int PARENT_ID { get; set; }

        // Связь многие-ко-многим с Character
        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
