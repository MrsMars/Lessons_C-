﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_34
{
    class BaseClass : IInterface
    {
        public string SayHello(string s)
        {
            return $"Hello {s}";
        }
    }
}