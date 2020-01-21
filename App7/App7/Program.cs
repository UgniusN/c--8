using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            double pakeltasSkaicius = pakeltiSkaiciu(5);
            Console.WriteLine(pakeltasSkaicius);
            Console.Read();
        }


        public static double pakeltiSkaiciu(double a)
        {
            return Math.Pow(a, 2);
        }
    }
}
