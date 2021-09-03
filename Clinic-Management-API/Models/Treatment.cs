using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_API.Models
{
    public class Treatment
    {
        [Key]
        public int Id { get; set; }
        public string streat_type { get; set; }
        // Relationship
        public ICollection<CheckUp> CheckUps { get; set; }
    }
}