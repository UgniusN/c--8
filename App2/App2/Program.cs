using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] vardai = {"Ugnius","Audrius", "Nojus", "Benas", "Jonas", "Rimas", "Nelsonas", "Gvidas"};
            spausdintiVarda(5, vardai);
            Console.Read();
        }


        public static void spausdintiVarda(int a,String [] b)
        {
            Random rand = new Random();
            int vardas = rand.Next(1, b.Length);
            for (int i=0; i<a; i++)
            {
                Console.WriteLine(b[vardas]);
            }

        }
    }
}
