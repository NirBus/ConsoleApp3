using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num3 = 0;
            //{
            //    if (num % 7 == 0)
            //    {
            //        Console.WriteLine(" 7-ye bolunur");
            //    }
            //    else
            //    {
            //        int num2 = num % 7; num3 = num - num2;
            //        Console.WriteLine(num3); ;
            //    }

            //    {

            //    }
            //}
            #endregion

            #region Task 2
            //////////int num1 = 0, num2 = 0, total = 0;
            //////////Console.WriteLine(" ");
            //////////num1 = Convert.ToInt32(Console.ReadLine());

            //////////Console.WriteLine(" ");
            //////////num2 = Convert.ToInt32(Console.ReadLine());

            //////////total = num1 + num2;
            /////Verilmis Ededleri tek tek yazin misal ucun 5 yazb enter vurduqdan sonra ikinci ededi toplamaq veya cixmaq ucun +5 veya -5 yazin.
            /////Console App:
            /////5
            /////+5
            /////=10
            Console.WriteLine(Sum());
            Console.WriteLine(Minus());
            Console.WriteLine(Divide());
            Console.WriteLine(X());
            #endregion 

        }
        #region Processing of TASK 2
        public static int Sum()
        {
            int num1 = 0, num2 = 0, total = 0;
            Console.Write(" ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" ");
            num2 = Convert.ToInt32(Console.ReadLine());


            total = num1 + num2;
            return total;

        }
        public static int Minus()
        {
            int num1 = 0, num2 = 0, total = 0;
            Console.Write(" ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" ");
            num2 = Convert.ToInt32(Console.ReadLine());

            total = num1 - num2;
            return total;
        }
        public static int Divide()
        {
            int num1 = 0, num2 = 0, total = 0;
            Console.Write(" ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" ");
            num2 = Convert.ToInt32(Console.ReadLine());

            total = num1 / num2;
            return total;

        }
        public static int X()
        {
            int num1 = 0, num2 = 0, total = 0;
            Console.WriteLine("");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            num2 = Convert.ToInt32(Console.ReadLine());

            total = num1 * num2;
            return total;
        }
        #endregion
    }
}












