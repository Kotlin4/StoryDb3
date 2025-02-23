using StoryDb3.Model.Entities.CharacterT;
using StoryDb3.Model.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryDb3.Model.Entities.ArchetypeT
{
    public class Archetype : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        // Внешний ключ для родителя
        public Guid? PARENT_ID { get; set; }
        // Навигационное свойство для родителя
        public Archetype? PARENT {  get; set; }
        // Коллекция дочерних элементов
        [ForeignKey(nameof(PARENT_ID))]
        public ICollection<Archetype> Children { get; set; } = new List<Archetype>();

        // Связь многие-ко-многим с Character
        public ICollection<Character> Characters { get; set; } = new List<Character>();

        // Связь многие-ко-многим с Characteristic
        public ICollection<Characteristic> Characteristics { get; set; } = new List<Characteristic>();
    }
}
