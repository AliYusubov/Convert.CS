using System;
using System.Diagnostics.Metrics;

namespace ALi
{
    class NumberManipulator
    {

        static void Main(string[] args)
        {
            int a = 75;
            float b = 53.005f;
            string c = "67";
            bool d = true;
            double e = 33;

            
            Console.WriteLine(Convert.ToDouble(a));
            Console.WriteLine(Convert.ToInt16(b));
            Console.WriteLine(Convert.ToInt32(c));
            Console.WriteLine(Convert.ToString(d));
            Console.WriteLine(Convert.ToString(e));
            Console.ReadKey();

        }


    }
}