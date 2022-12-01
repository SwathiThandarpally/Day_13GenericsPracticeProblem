using static FindingMaxUsingGenerics_13.UC_5ExtendMaxMethod;

namespace FindingMaxUsingGenerics_13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Finding Maximum Numbers By Using Generics");
           //UseCase1
            int[] intArray = { 100, 75, 50 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            Console.WriteLine("-----------------------------------");
            //UseCase2
            float[] floatArray = { 1.50f, 0.75f, 5.0f };
            GenericMaximum<float> genericFloat = new GenericMaximum<float>(floatArray);
            genericFloat.PrintMaxValue();
            Console.WriteLine("-----------------------------------");
            //UseCase3
            string[] stringArray = { "Appple", "Peach", "Banana" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.WriteLine("-----------------------------------");
            //REfactor1
            Console.WriteLine("Find max Number");
            int output = Refactor1.MaximumIntegerNumber(100, 75, 50);
            Console.WriteLine(output);
            float floatoutput = (float)Refactor1.MaximumFloatNumber(1.50f, 0.75f, 5.0f);
            Console.WriteLine(floatoutput);
            string strigoutput = Refactor1.MaximumStringNumber("Appple", "Peach", "Banana");
            Console.WriteLine(strigoutput);
            Console.WriteLine("-----------------------------------");
            //Refactor2
            Console.WriteLine("Maximum Integer Is:" + Refactor2<int>.findmax(100, 75, 50));
            Console.WriteLine("Maximum Float Is:" + Refactor2<float>.findmax(1.50f, 0.75f, 5.0f));
            Console.WriteLine("Maximum String Is:" + Refactor2<string>.findmax("Appple", "Peach", "Banana"));
            Console.WriteLine("-----------------------------------");
            //UseCase4
            Console.WriteLine("Maximum Integer Number is: ");
            int intoutput= UC_4ExtendMax.MaximumIntegerNumber(50,12,60,200);
            Console.WriteLine(intoutput);
            Console.WriteLine("Maximum Float Number is:");
            float output1 = UC_4ExtendMax.MaximumFloatNumber(3.33f, 50.40f, 80.7f, 21.60f);
            Console.WriteLine(output1);
            Console.WriteLine("Maximum String value is : ");
            string stringoutput = UC_4ExtendMax.MaximumStringNumber("Apple","Banana","PineApple","Peach");
            Console.WriteLine(stringoutput);
            Console.WriteLine("------------UC5--------------");
            //UseCase5
            int[] intArray={2, 344, 432, 555, 678 };
            GenericMaximum<int> generic1= new GenericMaximum<int>(intArray);
            generic1.PrintMaxValue();
            float[] float1= { 11.1f, 22.3f, 44.7f, 66.7f };
            GenericMaximum<float> generic2 = new GenericMaximum<float>(float1);
            generic2.PrintMaxValue();
            string[] string1= { "Apple", "Banana", "PineApple", "Peach" };
            GenericMaximum<string> genericString1 = new GenericMaximum<string>(string1);
            genericString1.PrintMaxValue();
            Console.ReadKey();


        }
    }
}