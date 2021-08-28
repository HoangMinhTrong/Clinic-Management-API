using Clinic_Management_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic_Management_API.Configurations
{
    public class CheckUpConfigurations : IEntityTypeConfiguration<CheckUp>
    {
        public void Configure(EntityTypeBuilder<CheckUp> builder)
        {
            builder.HasOne(x => x.AppUser)
                .WithMany(x => x.CheckUps)
                .HasForeignKey(x => x.user_id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Medicine)
                .WithMany(x => x.CheckUps)
                .HasForeignKey(x => x.med_id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
