using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Clinic_Management_API.Models.DataSeed
{
    public static class Seed
    {
        public static void Seeds(this ModelBuilder modelBuilder)
        {
            // Identity
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            
            modelBuilder.Entity<Treatment>().HasData(
                new Treatment
                {
                    Id = 1,
                    streat_type = "Cure hemorrhoids"
                },
                new Treatment
                {
                    Id = 2,
                    streat_type = "Lung disease treatment"
                }
            );
            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    Id = 1,
                    equip_name = "AED defibrillators",
                    requested_date = "01/01/2004",
                    date_defected = "01/01/2021"

                },
                new Equipment
                {
                    Id = 2,
                    equip_name = "Autoclave Sterilizer",
                    requested_date = "01/01/2004",
                    date_defected = "01/01/2021"
                }
            );
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = "1",
                    FirstName = "Nguyen",
                    LastName = "Ha",
                    UserName = "XuanHa",
                    Email = "tronggaw2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = "Admin@123"
                    
                }
            );
            modelBuilder.Entity<Medicine>().HasData(
                new Medicine
                {
                    Id = 1,
                    med_name = "Bandage",
                    quantity = 9,
                    available_qty = 999,
                    description = "Nothing",
                    expiry_date = "01/01/2019",
                    requested_date = "01/01/2021"
                }
            );
            modelBuilder.Entity<CheckUp>().HasData(
                new CheckUp
                {
                    Id = 1,
                    user_id = "1",
                    complain = "Nothing to Complain",
                    findings = "Cure hemorrhoids",
                    treat_id = 1,
                    med_id = 1,
                    quantity = "2",
                    date_time = "01/01/2021",
                    equip_id = 1
                }
            );
        }
    }
}