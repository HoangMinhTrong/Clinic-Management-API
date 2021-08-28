using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_API.Models
{
    public class Treatment
    {
        [Key]
        public int treat_id { get; set; }
        public string streat_type { get; set; }
        // Relationship
        public CheckUp CheckUp { get; set; }
    }
}