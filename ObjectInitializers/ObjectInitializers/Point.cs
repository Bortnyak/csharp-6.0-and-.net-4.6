﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    enum PointColor
    {
        LightBlue, BlooRed, Gold
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }
        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }
        public Point() : this(PointColor.BlooRed) { }

        public void DispalyStatus()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
        }
    }
}
