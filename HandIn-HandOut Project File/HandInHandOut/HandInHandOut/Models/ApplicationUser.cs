using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandInHandOut.Models
{
    public class ApplicationUser:IdentityUser
    {

        public string City { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public string State { get; set; }

    }
}
