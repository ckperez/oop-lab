using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Console.WriteLine("Enter a number to find the square root:");
                double num = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter an acceptable margin of error:");
                double tolerance = double.Parse(Console.ReadLine());
            */

            double num = double.Parse(args[0]);
            double tolerance = double.Parse(args[1]);
            
            Squirtulator sq = new Squirtulator(tolerance);
            double result = sq.getSquareRoot(num);

            SqrtTest validation = new SqrtTest();
            validation.validate();

            Console.WriteLine(result);
        }
    }
}
