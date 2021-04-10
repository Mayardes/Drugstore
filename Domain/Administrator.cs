using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.Models
{
    public class Administrator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public char Sex { get; set; }
        public string TelephoneNumber { get; set; }
        public string Document { get; set; }
    }
}
