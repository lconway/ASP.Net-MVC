﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    class Penguin: Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly!");
        }

        public override string ToString()
        {
            return "A peguin named " + base.Name;
        }
    }
}