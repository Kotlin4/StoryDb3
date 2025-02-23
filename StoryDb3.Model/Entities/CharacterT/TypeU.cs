using StoryDb3.Model.Services;

namespace StoryDb3.Model.Entities.CharacterT
{
    public class TypeU : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Навигационное свойство для CharacteristicU
        public CharacteristicU? CharacteristicU { get; set; }
    }
}
