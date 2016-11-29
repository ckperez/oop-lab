using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab
{
    class SqrtTest
    {
        public double getSquareRoot(double d)
        {
            return Math.Sqrt(d);
        }

        public void validate()
        {
            Random r = new Random();

            double tol = 0.0001;

            Squirtulator mySqrt = new Squirtulator(tol);

            int[] randNums = new int[10000];

            for (var i = 0; i < randNums.Length; i++)
            {
                randNums[i] = r.Next(100000);
                if( Math.Round(getSquareRoot(randNums[i]), 3) != Math.Round(mySqrt.getSquareRoot(randNums[i]), 3) )
                {
                    throw new Exception("Something's fucky!");
                };
                
            }
            Console.WriteLine("Looks accurate to me!");


        }

        public SqrtTest()
        {
        }
    }
}
