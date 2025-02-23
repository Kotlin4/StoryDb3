using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.ArchetypeT;

namespace StoryDb3.Model.Configuration.Relationships.ArchetypeT
{
    public class ArchetypeConfiguration : IEntityTypeConfiguration<Archetype>
    {
        public void Configure(EntityTypeBuilder<Archetype> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(a => a.Id);

            // Настройка рекурсивной связи для Archetype
            builder.HasOne(a => a.PARENT) // Один родитель
                .WithMany(p => p.Children) // Много дочерних элементов
                .HasPrincipalKey(a => a.PARENT_ID); // Внешний ключ

            // Настройка связи многие-ко-многим с Character
            builder.HasMany(a => a.Characters) // Много Characters
                .WithMany(c => c.Archetypes); // Много Archetypes

            // Настройка связи многие-ко-многим с Characteristic
            builder.HasMany(a => a.Characteristics)
                .WithMany(ch => ch.Archetypes);
        }
    }
}
