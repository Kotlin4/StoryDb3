using StoryDb3.Model.Entities.ArchetypeT;
using StoryDb3.Model.Entities.RaceT;
using StoryDb3.Model.Entities.SkillT;
using StoryDb3.Model.Services;

namespace StoryDb3.Model.Entities.CharacterT
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

        // Связь многие-ко-многим с CharacteristicU
        public ICollection<CharacteristicU> characteristicUs { get; set; } = new List<CharacteristicU>();

        // Связь один-ко-многим с Characteristic_Character
        public ICollection<Characteristic_Character> Characteristic_Characters { get; set; } = new List<Characteristic_Character>();

        // Навигационное свойство для Race
        public Race? Race { get; set; }

        // Связь многие-ко-многим с Skill
        public ICollection<Skill> Skills { get; set; } = new List<Skill>();
    }
}
