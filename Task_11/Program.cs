using System;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse
            //o zaman
            //bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.
            //Neticenin ustune ortaya dushen 2 reqemini gel.

            Console.WriteLine("Type 6 digit number: ");
            int num = Numcheck();

            int d1 = num / 100000;
            int d2 = (num / 10000) % 10;
            int d3 = (num / 1000) % 10;
            int d4 = (num / 100) % 10;
            int d5 = (num / 10) % 10;
            int d6 = (num % 10);

            if ((d1+d2+d3)==(d4+d5+d6))

            {
                int newnum = (d1 * 1000 + d2 * 100 + d5 * 10 + d6) +d3*10+d4;
                Console.WriteLine($"your new number is:{newnum}");
            }
            else
            { Console.WriteLine("Firtst 3 digit != Last 3 digit"); }

        }

        public static int Numcheck()

        {

        step1:
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 99999 && num < 1000000)
                {
                    Console.WriteLine("Your number is 6 digit");
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
