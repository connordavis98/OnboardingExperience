using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingExperience
{
    public class User
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAccountOwner { get; set; }
        public string PinNumber { get; set;  }
    }
}
