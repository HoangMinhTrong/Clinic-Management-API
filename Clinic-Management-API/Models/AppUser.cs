
using System;
using Microsoft.AspNetCore.Identity;

namespace Clinic_Management_API.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}