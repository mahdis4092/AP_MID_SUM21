﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CategoryDetail
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<ProductModel> products { get; set; }
    }
}
