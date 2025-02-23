using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities;

namespace StoryDb3.Model.Configuration.Relationships
{
    public class ArchetypeConfiguration : IEntityTypeConfiguration<Archetype>
    {
        public void Configure(EntityTypeBuilder<Archetype> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(a => a.Id);

            // Настройка связи многие-ко-многим с Character
            builder.HasMany(a => a.Characters)
                .WithMany(c => c.Archetypes);
        }
    }
}
