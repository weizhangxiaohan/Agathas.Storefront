﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Model.Products
{
    public interface IProductAttribute
    {
        int id { get; set; }
        string Name { get; set; }
    }
}
