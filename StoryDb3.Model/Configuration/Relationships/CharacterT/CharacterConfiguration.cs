using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.CharacterT;

namespace StoryDb3.Model.Configuration.Relationships.CharacterT
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(c => c.Id);

            // Настройка связи многие-ко-многим с Archetype
            builder.HasMany(c => c.Archetypes) // Много Archetypes
                .WithMany(a => a.Characters); // Много Characters

            // Настройка связи многие-ко-многим с CharacteristicU
            builder.HasMany(c => c.characteristicUs) // Много CharacteristicUs
                .WithMany(cu => cu.Characters); // Много Characters

            // Настройка связи многие-ко-многим с Skill
            builder.HasMany(c => c.Skills)
                .WithMany(s => s.Characters);
        }
    }
}
