using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(apskaiciuotiKMI(64, 1.80));
            Console.Read();
        }

        public static double apskaiciuotiKMI(int mase,double ugis)
        {
            return mase / Math.Pow(ugis, 2);
        }
    }
}
