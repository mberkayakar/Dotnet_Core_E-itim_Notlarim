﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product: IEntity
    {

        public int ProductID { get; set; }
        public int CategoryId{ get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitsInStock{ get; set; }
        public decimal UnitPrice { get; set; }
    }
}
