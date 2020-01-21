using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = { 5, 4, 3, 6, 7, 8 };
            int skaiciuSuma = grazintiMasyvoSuma(skaiciai);
            Console.WriteLine(skaiciuSuma);
            Console.Read();

        }

        public static int grazintiMasyvoSuma(int []a)
        {
            int suma = 0;
            for (int i = 0; i < a.Length; i++)
                suma += a[i];
            return suma;
        }
    }
}
