using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Demo : AbstractClassDemo
    {
        public int Length;
        public int Breadth;

        public double Length1;
        public double Breadth1;

        //public Demo(int Length, int brd)
        //{
        //    this.Length = Length;
        //    this.Breadth = brd;
        //}

        //public Demo(double Length, double brd)
        //{
        //    this.Length1 = Length;
        //    this.Breadth1 = brd;
        //}
        public Demo()
        {
            Console.WriteLine("Derived class Constructor");
        }
        public int FindArea()
        {
            int area;

            area = Length * Breadth;

            return area;
        }
        // calculating the perimeter
        public double FindAreaInDouble()
        {
            double area;

            area = Length1 * Breadth1;

            return area;
        }

        public int FindPerimeter()
        {
            int perimeter;

            perimeter = 2 * (Length + Breadth);

            return perimeter;
        }

        public override void show1()
        {
            Console.WriteLine("Child Class");
        }
    }
}
