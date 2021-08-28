
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Clinic_Management_API.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Relationship
        public ICollection<CheckUp> CheckUps { get; set; }
    }
}