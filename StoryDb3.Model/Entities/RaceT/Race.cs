using StoryDb3.Model.Entities.CharacterT;
using StoryDb3.Model.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryDb3.Model.Entities.RaceT
{
    public class Race : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        [ForeignKey("Character")]
        public Guid? Character_ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        // Внешний ключ для родителя
        public Guid? PARENT_ID { get; set; }
        // Навигационное свойство для родителя
        public Race? PARENT { get; set; }

        // Коллекция дочерних элементов
        [ForeignKey(nameof(PARENT_ID))]
        public ICollection<Race> Children { get; set; } = new List<Race>();

        // Навигационное свойство для Character
        public Character? Character { get; set; }
    }
}
