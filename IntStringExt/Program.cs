using System;
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
            
            string x = "Hello";
            x.Y(23);
            x.X();
        }
    }
    static class Red
    {
        public static void X(this string value)
        {
            Console.WriteLine(value);
        }


    public static void Y(this string value,int l)
        {
            Console.WriteLine(value + l);
        }
}

}
