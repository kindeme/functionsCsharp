using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            Circle C2 = new Circle(10);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);

            Console.ReadLine();
        }
        
    }


    class Circle
    {
        float PI = 3.141F;
        int Radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public float CalculateArea()
        {
            return this.PI * this.Radius * this.Radius;
        }
    }
}
