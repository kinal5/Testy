using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{

    class Program
    {
        static List<int> Factors(int n)
        {
            List<int> list = new List<int>();
            int i = 2;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                    n /= i;
                }
                else
                    i++;
            }
            return list;
        }

        static int Calc(int n)
        {
            var factors = Enumerable.Range(2, n - 1).Select(j => Factors(j)).ToList();


            int i = 2;
            int res = 1;
            while (i <= n)
            {
                if (factors.Count(l => l.Contains(i)) > 1)
                {
                    factors.ForEach(l => l.Remove(i));
                    res *= i;
                }
                else
                    i++;
            }

            return res * factors.SelectMany(x => x).Aggregate((s, j) => s *= j);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calc(2));
            Console.WriteLine(Calc(3));
            Console.WriteLine(Calc(5));
            Console.WriteLine(Calc(7));
            Console.WriteLine(Calc(10));
            Console.WriteLine(Calc(20));
            Console.ReadKey();
        }
    }
}
