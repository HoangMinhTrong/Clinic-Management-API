
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Clinic_Management_API.Models.DTOs
{
    public class AppUserDTOs : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}