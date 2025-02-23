using StoryDb3.Model.Services;

namespace StoryDb3.Model.Entities.ArchetypeT
{
    public class Characteristic : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Min {  get; set; }
        public int Max { get; set; }
        public int Default { get; set; }

        // Связь многие-ко-многим с Archetype
        public ICollection<Archetype> Archetypes { get; set; } = new List<Archetype>();

        // Связь один-ко-многим с Characteristic_Character
        public ICollection<Characteristic_Character> Characteristic_Characters { get; set; } = new List<Characteristic_Character>();
    }
}
