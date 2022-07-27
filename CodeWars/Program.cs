using System;
using System.Collections.Generic;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long add = 348597;
            long[] addNum = new long[] { 7, 9, 5, 8, 4, 3 };
            Console.WriteLine(Reversed(add));

            foreach (var item in Digitize(add))
            {
                Console.WriteLine(item);
            }
           
        }

        public static long[] Digitize(long n)
        {
            long rem;
            List<long> num = new List<long>();
            //if (n == 0)
            //   {
            //        num.Add(0);
            //   }
                do
                {
                    rem = n % 10;
                    n = n / 10;
                    num.Add(rem);
                } 
                while (n != 0);
            return num.ToArray();
        }

        public static long Reversed(long n)
        {
            long rem, reverse = 0;
            
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;

            }

            return reverse;


        }

        public static long[] Digitize2(long n)
        {
            long rem;
            List<long> num = new List<long>();
            if (n == 0)
            {
                num.Add(0);
            }
            while (n != 0)
            {
                rem = n % 10;
                n = n / 10;
                num.Add(rem);
            }

            return num.ToArray();
        }
    }
}
