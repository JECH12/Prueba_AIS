﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public  interface IOrder
    {
        public int[] GetOrdererNumbers(int[] numbers);
    }
}