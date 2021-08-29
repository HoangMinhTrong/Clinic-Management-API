using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace Clinic_Management_API.Models.DTOs
{
    public class CheckUpDTOs
    {
        public int check_id { get; set; }
        public string user_id { get; set; }
        public string complain { get; set; }
        public string findings { get; set; }
        public int treat_id { get; set; }
        public int med_id { get; set; }
        public string quantity { get; set; }
        public string date_time { get; set; }
        public int equip_id { get; set; }
    }
}