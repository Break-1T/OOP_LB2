using System;
//Ещё не доделал, т.к. не могу понять условие.

namespace MainController._2_nd_lb_classes
{
    class Point
    {
        public double side1;
        public double side2;
        public string Name;

        public double side3 { get; }
        public double side4 { get; }
        public double side5 { get; }

        public Point(string Name, double side1=0, double side2=0, double side3=0, double side4=0, double side5=0)
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
