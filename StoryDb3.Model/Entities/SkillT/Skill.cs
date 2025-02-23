using StoryDb3.Model.Entities.CharacterT;
using StoryDb3.Model.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryDb3.Model.Entities.SkillT
{
    public class Skill : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        public Guid? Level_ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =string.Empty;

        // Связь один-ко-многим с Level
        [ForeignKey("Level_ID")]
        public Level? Level { get; set; }

        // Связь многие-ко-многим с Character
        public ICollection<Character> Characters { get; set; } = new List<Character>();
        // Связь многие-ко-многим с Archetype
    }
}
