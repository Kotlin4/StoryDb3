using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb3.Model.Entities.ArchetypeT;

namespace StoryDb3.Model.Configuration.Relationships.ArchetypeT
{
    public class Characteristic_CharacterConfiguration : IEntityTypeConfiguration<Characteristic_Character>
    {
        public void Configure(EntityTypeBuilder<Characteristic_Character> builder)
        {
            // Связь с Character
            builder.HasOne(cc => cc.Character)
                .WithMany(c => c.Characteristic_Characters)
                .HasForeignKey(cc => cc.Character_ID);

            // Связь с Characteristic
            builder.HasOne(cc => cc.Characteristic)
                .WithMany(ch => ch.Characteristic_Characters)
                .HasForeignKey(cc => cc.Characteristic_ID);

            

        }
    }
}
