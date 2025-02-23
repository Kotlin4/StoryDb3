using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb3.Model.Configuration.Relationships
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(c => c.Id);

            // Настройка связи многие-ко-многим с Archetype
            builder.HasMany(c => c.Archetypes)
                .WithMany(a => a.Characters);
        }
    }
}
