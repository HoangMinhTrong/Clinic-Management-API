using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_API.Models
{
    public class Treatments
    {
        [Key]
        public int treat_id { get; set; }
        public string streat_type { get; set; }
    }
}