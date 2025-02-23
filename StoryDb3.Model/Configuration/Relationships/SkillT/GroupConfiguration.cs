using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.SkillT;

namespace StoryDb3.Model.Configuration.Relationships.SkillT
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(gs => gs.Id);

            // Настройка рекурсивной связи для Group
            builder.HasOne(gs => gs.PARENT) // Один родитель
                .WithMany(p => p.Children) // Много дочерних элементов
                .HasForeignKey(gs => gs.PARENT_ID); // Внешний ключ
        }
    }
}
