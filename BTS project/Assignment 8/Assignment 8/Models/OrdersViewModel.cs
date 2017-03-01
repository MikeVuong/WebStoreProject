﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_8.Models
{
    public class OrdersViewModel
    {
        [Key]
        public int OrderID { get; set; }
        public string Name { get; set; }
        public List<CheckBoxViewModel> Products { get; set; }
    }
}