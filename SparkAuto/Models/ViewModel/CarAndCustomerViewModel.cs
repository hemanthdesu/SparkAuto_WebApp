﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkAuto.Models.ViewModel
{
    public class CarAndCustomerViewModel
    {
        public ApplicationUser Userobj { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}