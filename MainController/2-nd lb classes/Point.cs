using System;

namespace MainController._2_nd_lb_classes
{
    class Point
    {
        public int side1;
        public int side2;
        public string Name;

        public int side3 { get; }
        public int side4 { get; }
        public int side5 { get; }

        public Point(string Name, int side1, int side2, int side3=0, int side4=0, int side5=0)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
            this.side5 = side5;
            this.Name = Name;
        }
    }
    class Figure
    {
        public Figure(Point A,Point B,Point C)
        {

        }
        public Figure(Point A, Point B, Point C,Point D)
        {

        }
        public Figure(Point A, Point B, Point C,Point D,Point E)
        {

        }

        public double LengthSide(Point A,Point B)//Длина стороны многоугольника
        {
            return 0;
        }
        public void PerimetrCalculator()//Периметр многоугольника
        {
            Console.WriteLine($"Perimeter of ");
        }
    }
}
