using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.Write("Area = ");
            Console.WriteLine(Area(radius));
            Console.Write("Perimeter = ");
            Console.WriteLine(Perimeter(radius));

        } 
        static double Area (double r)
        {
            double area = Math.PI * r * r;
            return area;
        } 
        static double Perimeter (double r)
        {
            double perimeter = 2 * Math.PI * r;
            return perimeter;
        }
    }
}
