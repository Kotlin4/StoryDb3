using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.SkillT;

namespace StoryDb3.Model.Configuration.Relationships.SkillT
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(s => s.Id);

            // Настройка связи один-ко-многим с Level
            builder.HasOne(s => s.Level) // Один Level
                .WithMany(sl => sl.Skills) // Много Skill
                .HasForeignKey(s => s.Level_ID); // Внешний ключ

            // Настройка связи многие-ко-многим с Character
            builder.HasMany(s => s.Characters)
                .WithMany(c => c.Skills);
        }
    }
}
