using System;

namespace StFormTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ParityTest1(1));
            Console.WriteLine(ParityTest1(2));
            Console.WriteLine("");
            Console.WriteLine(ParityTest2(1));
            Console.WriteLine(ParityTest2(2));
            Console.WriteLine("");
            Console.WriteLine(ParityTest3(1));
            Console.WriteLine(ParityTest3(2));
        }
        static bool ParityTest1(int number)
        {
            if (number % 2 == 0)
                return true;
            else return false;

        }
        static bool ParityTest2(int number)
        {
            string binNumberStr = Convert.ToString(number, 2);
            if (binNumberStr.Substring(binNumberStr.Length - 1) == "0")
                return true;
            else return false;

        }

        static bool ParityTest3(int number)
        {
            int logicResult = number & 1;
            return !Convert.ToBoolean(logicResult);

        }
    }
}
