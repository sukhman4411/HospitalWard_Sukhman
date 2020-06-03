using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalWard_Sukhman.Models
{
    public class Ward
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int NurseID { get; set; }
        public Nurse Nurse { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }
}