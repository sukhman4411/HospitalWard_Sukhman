using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalWard_Sukhman.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int WardID { get; set; }
        public Ward Ward { get; set; }
    }
}