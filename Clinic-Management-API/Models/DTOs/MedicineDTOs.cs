﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Management_API.Models.DTOs
{
    public class MedicineDTOs
    {
        public int med_id { get; set; }
        public string med_name { get; set; }
        public int quantity  { get; set; }
        public int available_qty { get; set; }
        public string description { get; set; }
        public string expiry_date { get; set; }
        public string requested_date { get; set; }
    }
}