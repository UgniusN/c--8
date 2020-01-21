using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            groteles(5);
            Console.Read();
        }


        public static void groteles(int kiekis)
        {
            for(int i=0; i<kiekis; i++)
                Console.Write("#");
        }
    }
}
