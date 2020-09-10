using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainController._2_nd_lb_classes
{
    class Point
    {
        public int field1;
        public int field2;
        public string field3;

        public string property1 { get; }
        public string property2 { get; }
        public string property3 { get; }
        public Point(int field1=0, int field2=0, string field3="Null")
        {
            this.field1 = field1;
            this.field2 = field2;
            this.field3 = field3;
        }
        
    }
    class Figure
    {
        public Figure(Point A,Point B,Point C)
        {

        }
    }
}
