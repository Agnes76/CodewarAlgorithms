using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long add = 348597;
            //long[] addNum = new long[] { 7, 9, 5, 8, 4, 3 };
            //Console.WriteLine(Reversed(add));

            //foreach (var item in Digitize(add))
            //{
            //    Console.WriteLine(item);
            //}

            int[] nums = new int[] { 34, 15, 88, 2 };
            int[] num2 = new int[] { 34, -345, -1, 100 };
            //Console.WriteLine(FindSmallestInt(nums));
            //Console.WriteLine(FindSmallestInt(num2));
            //Console.WriteLine(FindSmallestInt2(nums));
            Console.WriteLine(FindSmallestInt2(num2));
            Console.WriteLine(FindSmallestInt3(num2));
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

//        Given an array of integers your solution should find the smallest integer.

//For example:

//Given[34, 15, 88, 2] your solution will return 2
//Given[34, -345, -1, 100] your solution will return -345
//You can assume, for the purpose of this kata, that the supplied array will not be empty.
        public static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }

        public static int FindSmallestInt2(int[] args)
        {
            int minNum = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                //Console.WriteLine(args[i]);
                if (minNum > args[i])
                {      
                    minNum = args[i];
                }
            }
            return minNum;
        }

        public static int FindSmallestInt3(int[] args)
        {
            int minNum = args[0];

            foreach (int item in args)
            {
                if (item < minNum)
                {
                    minNum = item;
                }
            }
            return minNum;
        }
    }
}
