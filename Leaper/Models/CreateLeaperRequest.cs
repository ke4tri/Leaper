using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leap.Models
{
    public class CreateLeaperRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TargetLeap { get; set; }
    }
}

