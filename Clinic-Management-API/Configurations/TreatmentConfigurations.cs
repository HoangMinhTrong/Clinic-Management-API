using Clinic_Management_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Clinic_Management_API.Configurations
{
    public class TreatmentConfigurations : IEntityTypeConfiguration<Treatment>
    {
        public void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder.HasOne(x => x.CheckUp)
                .WithMany(x => x.Treatments)
                .HasForeignKey(x => x.treat_id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}