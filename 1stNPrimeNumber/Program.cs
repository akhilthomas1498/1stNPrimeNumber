using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stNPrimeNumber
{
    internal class Program
    {
        public int div(int i)
        {
            int x = 0;
            for (int j = 2; j <= (i / 2); j++)
                if (i % j == 0)
                    x++;
            return x;
        }
        static void Main(string[] args)
        {
            Console.Write("\nEnter the limit: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            Console.WriteLine("Prime numbers are");
            for(int i = 2 ; i <= n; i++)
            {
                if(0==p.div(i))
                    Console.WriteLine(i);
            }
            Console.ReadLine(); 
        }
    }
}
