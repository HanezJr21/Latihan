﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Models
{
    public class Menu
    {
        public long id { get; set; }
        public string namaMakanan { get; set; }
        public double hargaMakanan { get; set; }
    }
}
