using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leaper.Modeles
{
    public class Leaper
    {
        public Leaper(string first_name, string last_name, int target_leap)
        {
            First_Name = first_name;
            Last_Name = last_name;
            Target_Leap = target_leap;
        }

        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Target_Leap { get; set; }

    }
}
