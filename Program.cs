using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main()
        {
            // Example usage
            // double x1 = 0, y1 = 0; // Endpoint 1
            // double x2 = 3, y2 = 4; // Endpoint 2

            // Line line = new Line(x1, y1, x2, y2);
            //double length = line.CalculateLength();

            //Console.WriteLine("The length of the line is: " + length);

            // Example usage
            //double x1 = 0, y1 = 0; // Endpoint 1 of Line 1
            //double x2 = 3, y2 = 4; // Endpoint 2 of Line 1

            //double x3 = 0, y3 = 0; // Endpoint 1 of Line 2
            //double x4 = 3, y4 = 4; // Endpoint 2 of Line 2

            //Line line1 = new Line(x1, y1, x2, y2);
            //Line line2 = new Line(x3, y3, x4, y4);

            // bool areEqual = line1.Equals(line2);

            //Console.WriteLine("Are the lines equal? " + areEqual);


            
                // Example usage
                double x1 = 0, y1 = 0; // Endpoint 1 of Line 1
                double x2 = 3, y2 = 4; // Endpoint 2 of Line 1

                double x3 = 0, y3 = 0; // Endpoint 1 of Line 2
                double x4 = 3, y4 = 4; // Endpoint 2 of Line 2

                Line line1 = new Line(x1, y1, x2, y2);
                Line line2 = new Line(x3, y3, x4, y4);

                int comparisonResult = line1.CompareTo(line2);

                if (comparisonResult == 0)
                {
                    Console.WriteLine("The lines are equal.");
                }
                else if (comparisonResult < 0)
                {
                    Console.WriteLine("Line 1 is less than Line 2.");
                }
                else
                {
                    Console.WriteLine("Line 1 is greater than Line 2.");
                }
            



        }
    }
}
