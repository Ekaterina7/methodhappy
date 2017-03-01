using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sschislenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;

        int b = SystemCaLC(a);
        Console.WriteLine(b);
        }

        static int  SystemCaLC(int a)
        {
            string s = " ";
            
            int tempostotok = 0;
            while (a != 0)
            {
                a = a / 2;
                tempostotok = a % 2;
                s = Convert.ToString(tempostotok) + s;
               
            }

            return Convert.ToInt32(s);
           
            


        }
    }
}
