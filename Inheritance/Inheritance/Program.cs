// oshakuade oluwasola john
// Advanced C#
// Oct 1st
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfClasses
{
    class Shape
    {
        private int width;
        private int height;
        public Shape()
        {

        }
        public void setWidth(int w) { width = w; }
        public void setHeight(int h) { height = h; }
        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }
    }

    class Rectangle : Shape
    {
        public void setWandH(int w, int h)
        {
            setHeight(w); setWidth(h);
        }
        public int GetArea()
        {
            return (getWidth() * getHeight());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Rectangle r1 = new Rectangle();
            s1.setHeight(11);
            s1.setWidth(10);
            Console.WriteLine("Height = {0} Width = {1}", s1.getHeight(), s1.getWidth());
            r1.setWandH(3, 5);
            Console.WriteLine("The area = {0}", r1.GetArea());
            Console.WriteLine("Hello from the other side.");
            Console.ReadKey();
        }
    }



}
