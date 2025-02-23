using StoryDb3.Model.Services;
using System.ComponentModel.DataAnnotations.Schema;
namespace StoryDb3.Model.Entities.SkillT
{
    public class Group : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        // Внешний ключ для родителя
        public Guid? PARENT_ID { get; set; }
        // Навигационное свойство для родителя
        public Group? PARENT { get; set; }
        // Коллекция дочерних элементов
        [ForeignKey(nameof(PARENT_ID))]
        public ICollection<Group> Children { get; set; } = new List<Group>();

        // Связь один-ко-многим с Level
        public ICollection<Level> Levels { get; set; } = new List<Level>();
    }
}
