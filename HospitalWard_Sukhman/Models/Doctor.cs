using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalWard_Sukhman.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string DoctorName { get; set; }
        public string Specialty { get; set; }
        public List<Ward> Wards { get; set; }
    }
}