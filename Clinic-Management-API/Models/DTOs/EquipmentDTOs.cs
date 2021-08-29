using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_API.Models.DTOs
{
    public class EquipmentDTOs
    {
        public int equip_id { get; set; } 
       public string equip_name { get; set; }
       public string requested_date { get; set; }
       public string date_defected { get; set; }

    }
}