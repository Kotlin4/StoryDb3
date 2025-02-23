using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.ArchetypeT;

namespace StoryDb3.Model.Configuration.Relationships.ArchetypeT
{
    public class CharacteristicConfiguration : IEntityTypeConfiguration<Characteristic>
    {
        public void Configure(EntityTypeBuilder<Characteristic> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(ch => ch.Id);

            // Настройка связи многие-ко-многим с Archetype
            builder.HasMany(ch => ch.Archetypes) // Много Archetypes
                .WithMany(a => a.Characteristics); // Много Characteristics
        }
    }
}
