using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SparkAuto.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        public String Name { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String PostalCode { get; set; }

    }
}
