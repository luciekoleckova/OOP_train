﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_cv
{
    class Door
    {
        private double height;
        private double width;
        public double Height { get { return height; } set { height = value; } }
        public double Width { get { return width; } set { width = value; } }
        public Door(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
    }
}
