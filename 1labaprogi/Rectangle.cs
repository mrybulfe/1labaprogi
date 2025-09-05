using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1labaprogi
{
    class Rectangle
    {
        private Point2d p1;
        private Point2d p2;
        private Point2d p3;
        private Point2d p4;
        public Rectangle(Point2d p1, Point2d p2, Point2d p3, Point2d p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
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
        public Point2d getP4()
        {
            return p4;
        }
        public void addX(int X)
        {
            p1.addX(X);
            p2.addX(X);
            p3.addX(X);
            p4.addX(X);
        }
        public void addY(int Y)
        {
            p1.addY(Y);
            p2.addY(Y);
            p3.addY(Y);
            p4.addX(Y);
        }
    }
}
