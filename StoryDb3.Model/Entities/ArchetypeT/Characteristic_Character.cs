using Microsoft.EntityFrameworkCore;
using StoryDb3.Model.Entities.CharacterT;
using StoryDb3.Model.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoryDb3.Model.Entities.ArchetypeT
{
    [PrimaryKey(nameof(Character_ID), nameof(Characteristic_ID))]
    public class Characteristic_Character : IModelTable
    {
        // Первичный ключ (композитный)
        public Guid Character_ID { get; set; }
        public Guid Characteristic_ID { get; set; }

        // Дополнительное свойство
        public int Value { get; set; }

        // Навигационные свойств
        [ForeignKey(nameof(Character_ID))]
        public Character Character { get; set; } = null!;
        [ForeignKey(nameof(Characteristic_ID))]
        public Characteristic Characteristic { get; set; } = null!;
       
    }
}
