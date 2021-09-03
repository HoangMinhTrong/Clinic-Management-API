using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_API.Models
{
    public class Equipment
    { 
        [Key]
       public int Id { get; set; }
       public string equip_name { get; set; }
       public string requested_date { get; set; }
       public string date_defected { get; set; }
       // Relationship
       public ICollection<CheckUp> CheckUps { get; set; }
    }
}