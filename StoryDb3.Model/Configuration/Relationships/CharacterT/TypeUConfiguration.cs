using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.CharacterT;

namespace StoryDb3.Model.Configuration.Relationships.CharacterT
{
    public class TypeUConfiguration : IEntityTypeConfiguration<TypeU>
    {
        public void Configure(EntityTypeBuilder<TypeU> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(tu => tu.Id);

           
        }
    }
}
