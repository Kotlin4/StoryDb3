using StoryDb3.Model.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryDb3.Model.Entities.CharacterT
{
    public class CharacteristicU : IModelTable
    {
        // Поля таблиц
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [ForeignKey("TypeU")] // Явно указываем, что это внешний ключ для TypeU
        public Guid? TypeU_ID { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }
        public int Default {  get; set; }

        // Навигационное свойство для TypeU
        public TypeU? TypeU {  get; set; }

        // Связь многие-ко-многим с Character
        public ICollection<Character> Characters { get; set;} = new List<Character>();
    }
}
