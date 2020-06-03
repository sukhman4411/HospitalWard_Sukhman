using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalWard_Sukhman.Models
{
    public class Nurse
    {
        public int ID { get; set; }
        public string NurseName { get; set; }
        public string Specialty { get; set; }
        public List<Ward> Wards { get; set; }
    }
}