using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaxUsingGenerics_13
{
    public class Refactor1
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber, secondNumber, thirdNumber are same");

        }
        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber, secondNumber, thirdNumber are same");

        }
        public static string MaximumStringNumber(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0 ||
             firststring.CompareTo(secondstring) >= 0 && firststring.CompareTo(thirdstring) > 0 ||
             firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) >= 0)
            {
                return firststring;
            }
            

            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0 ||
               secondstring.CompareTo(firststring) >= 0 && secondstring.CompareTo(thirdstring) > 0 ||
               secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) >= 0)
            {
                return secondstring;
            }
          

            if (thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) > 0 ||
               thirdstring.CompareTo(firststring) >= 0 && thirdstring.CompareTo(secondstring) > 0 ||
               thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) >= 0)
            {
                return thirdstring;
            }
            throw new Exception("firststring, secondstring, thirdstring are same");
            return firststring;

        }
    }
}
