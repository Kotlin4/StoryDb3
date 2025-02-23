using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.CharacterT;

namespace StoryDb3.Model.Configuration.Relationships.CharacterT
{
    public class CharacteristicUConfiguration : IEntityTypeConfiguration<CharacteristicU>
    {
        public void Configure(EntityTypeBuilder<CharacteristicU> builder)
        {
            // Настройка первичного ключа
            builder.HasKey(cu => cu.Id);

            // Настройка связи многие-ко-многим с Character
            builder.HasMany(cu => cu.Characters) // Много Characters
                .WithMany(c => c.characteristicUs); // Много CharacteristicUs

            // Настройка связи один-к-одному с TypeU
            builder.HasOne(cu => cu.TypeU) // Один TypeU
                .WithOne(tu => tu.CharacteristicU) // Один CharacteristicU
                .HasForeignKey<CharacteristicU>(cu => cu.TypeU_ID); // Внешний ключ
        }
    }
}
