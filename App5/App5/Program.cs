using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teksta");
            String tekstas = Console.ReadLine();
            int tarpuEiluteje = surastiTarpus(tekstas);
            Console.WriteLine(tarpuEiluteje);
            Console.Read();
        }

        public static int surastiTarpus (String a)
        {
            int tarpai = 0;
            foreach(char letter in a)
            {
                if (letter == ' ')
                    tarpai++;
            }
            return tarpai;
        }
    }
}
