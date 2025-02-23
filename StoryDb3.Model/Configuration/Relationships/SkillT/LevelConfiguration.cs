using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.SkillT;

namespace StoryDb3.Model.Configuration.Relationships.SkillT
{
    public class LevelConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(ls => ls.Id);

            // Настройка рекурсивной связи для Level
            builder.HasOne(ls => ls.PARENT) // Один родитель
                .WithOne(p => p.Child) // Один дочерний элемент
                .HasForeignKey<Level>(ls => ls.PARENT_ID); // Внешний ключ

            // Настройка связи один-ко-многим с Group
            builder.HasOne(ls => ls.Group) // Одна Group
                .WithMany(gl => gl.Levels) // Много Levels
                .HasForeignKey(ls => ls.Group_ID); // Внешний ключ

        }
    }
}
