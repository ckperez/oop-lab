using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab
{
    class Squirtulator
    {

        double Tolerance;

        public Squirtulator(double tolerance)
        {
            if(tolerance >= 0)
            {
                Tolerance = tolerance;
            }
            else
            {
                throw new Exception("Must be a positive number!");
            }
        }

        public double getSquareRoot(double val)
        {
            double n = val;

            double G = n / 2;

            while (G * G < n - Tolerance || G * G > n + Tolerance)
            {
                G = (G + (n / G)) / 2;
            }

            return G;
        }
    }
}
