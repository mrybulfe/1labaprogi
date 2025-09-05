﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1labaprogi
{
    class Triangle
    {
        private Point2d p1;
        private Point2d p2;
        private Point2d p3;

        public Triangle(Point2d p1, Point2d p2, Point2d p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3!;
        }
        public Point2d getP1()
        {
            return p1;
        }
        public Point2d getP2()
        {
            return p2;
        }
        public Point2d getP3()
        {
            return p3;
        }
        public void addX(int X)
        {
            p1.addX(X);
            p2.addX(X);
            p3.addX(X);
        }
        public void addY(int Y)
        {
            p1.addY(Y);
            p2.addY(Y);
            p3.addY(Y);
        }
    }
}
