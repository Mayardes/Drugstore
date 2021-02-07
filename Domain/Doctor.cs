using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set;}
        public string State { get; set;}
        public int MedicalRegister { get; set; }
        public string Password { get; set;}
        public string MedicalSpecialty { get; set;}

    }
}
