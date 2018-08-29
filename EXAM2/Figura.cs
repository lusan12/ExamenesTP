﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    abstract class Figura
    {
        protected  double x;
        protected  double y;
        protected  double area;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Area { get => area; set => area = value; }
        public abstract void CalcularArea();
    }
}
