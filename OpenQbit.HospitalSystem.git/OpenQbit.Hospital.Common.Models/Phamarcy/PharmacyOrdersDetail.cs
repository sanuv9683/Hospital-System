﻿
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenQbit.Hospital.Common.Models.Phamarcy
{
    public class PharmacyOrdersDetail
    {
        public int ID { get; set; }

        public int orderQty { get; set; }

        public String ItemName { get; set; }

        public double unitPrice { get; set; }

        public double itemTotalPrice { get; set; }

        public virtual Category Category { get; set; }
    }
}