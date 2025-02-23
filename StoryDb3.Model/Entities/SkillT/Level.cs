using StoryDb3.Model.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryDb3.Model.Entities.SkillT
{
    public class Level : IModelTable
    {
        public Guid Id { get; set; }
        public Guid? Group_ID {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        // Внешний ключ для родителя
        public Guid? PARENT_ID { get; set; }
        // Навигационное свойство для родителя
        public Level? PARENT {  get; set; }
        // Навигационное свойство дочернего элементоа
        [ForeignKey("PARENT_ID")]
        public Level? Child { get; set; }

        // Связь один-ко-многим с Skill
        public ICollection<Skill> Skills { get; set; } = new List<Skill>();

        // Связь один-ко-многим с Group
        [ForeignKey("Group_ID")]
        public Group? Group { get; set; }
    }
}
