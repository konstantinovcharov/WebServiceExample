﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceLib
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }
    }
}
