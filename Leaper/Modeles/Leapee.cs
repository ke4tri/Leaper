using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leaper.Modeles
{
    public class Leapee
    {

        public Leapee(string first_name, string last_name)
        {
            First_Name = first_name;
            Last_Name = last_name;
            
        }

        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        
    }
}
