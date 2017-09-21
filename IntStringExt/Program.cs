﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStringExt
{
       
    class Program
    {

        static void Main(string[] args)
        {
            int k = 15;
            Console.WriteLine( k.IsOdd());
            Console.WriteLine(k.AddNum(12));
            string kl = "Hello World";
        
        }


    }

    public static class IntExtensions
    {
        public static bool IsOdd(this int k)
        {
           
            return k % 2 == 0;
        }

        public static double AddNum(this int l,double k)
        {
            return k + l;
        }
    }
}
