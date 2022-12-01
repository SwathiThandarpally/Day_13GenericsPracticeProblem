using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaxUsingGenerics_13
{
    internal class UC_3FindMaxString
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
