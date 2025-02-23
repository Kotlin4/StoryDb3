using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.RaceT;

namespace StoryDb3.Model.Configuration.Relationships.RaceT
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(r => r.Id);

            // Настройка рекурсивной связи для Race
            builder.HasOne(r => r.PARENT) // Один родитель
                .WithMany(p => p.Children) // Много дочерних элементов
                .HasForeignKey(r => r.PARENT_ID); // Внешний ключ

            // Настройка связи один-к-одному с Character
            builder.HasOne(r => r.Character)
                .WithOne(c => c.Race)
                .HasForeignKey<Race>(r => r.Character_ID);
        }
    }
}
