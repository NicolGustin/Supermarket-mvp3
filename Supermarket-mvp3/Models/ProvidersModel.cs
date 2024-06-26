﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp3.Models
{
    internal class ProvidersModel
    {
        [DisplayName("Providers Id")]
        public int Id { get; set; }
        [DisplayName("Providers Name")]
        [Required(ErrorMessage = "Providers name is requered")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Product name must be between 3 and 50 characters")]

        public string Name { get; set; }
        [DisplayName("Providers Observation")]
        [Required(ErrorMessage = "Providers observation is requered")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Providers observation must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}
