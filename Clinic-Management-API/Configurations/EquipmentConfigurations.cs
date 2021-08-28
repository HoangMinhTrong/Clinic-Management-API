using Clinic_Management_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Clinic_Management_API.Configurations
{
    public class EquipmentConfigurations : IEntityTypeConfiguration<Equipment>
    {
         public void Configure(EntityTypeBuilder<Equipment> builder) 
         {
            builder.HasOne(x => x.CheckUp)
            .WithMany(x => x.Equipments)
            .HasForeignKey(x => x.equip_id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
         }
    }
}