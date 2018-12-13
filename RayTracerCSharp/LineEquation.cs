﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerCSharp
{
    public class LineEquation
    {
        public double Gradient { get; private set; }
        public double Offset { get; private set; }

        public LineEquation(double gradient, double offset)
        {
            Gradient = gradient;
            Offset = offset;
        }

        public LineEquation(Line l)
        {
            Gradient = (double)l.DY / l.DX;
            Offset = l.FirstPoint.Y - Gradient * l.FirstPoint.X;
        }
    }
}
