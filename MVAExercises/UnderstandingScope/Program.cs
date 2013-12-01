using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k;
        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

             }

            helperMethod();
            Console.ReadLine();

        }

        private static void helperMethod()
        {
            Console.WriteLine("k:" + k);
        }
    }
}
