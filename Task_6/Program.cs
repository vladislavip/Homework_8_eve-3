using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //6) Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi? Beli ve Xeyr cavabini yaz ekrana
            Console.WriteLine("Type your 3 digit number ");


            int num1 = Numcheck();

            int d1 = num1 / 100;
            int d2 = (num1 /10)% 10;
            int d3 = (num1 % 10);

            Console.WriteLine($"First digit is:{d1}");
            Console.WriteLine($"Second digit is:{d2}");
            Console.WriteLine($"Third digit is: {d3}");

            if ((d1+d3)==d2)


            {
                Console.WriteLine("Yes (Dig.1+Dig.3 == Dig.2)");

            }
            else

            {
                Console.WriteLine("No (Dig.1+Dig.3 != Dig.2)");
            }










                    
                   



        }



        public static int Numcheck()

        {

        step1:
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 99 && num < 1000)
                {
                    Console.WriteLine("Your number is 3 digit");
                }
                else
                {
                    Console.WriteLine("Wrong number");
                    goto step1;
                }

                return num;


            }

            catch

            {
                Console.WriteLine("Use only numbers");

                goto step1;

            }
        }
    }
}
