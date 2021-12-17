using System;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //12) Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir.
            //Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
            //Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.

            //Console.WriteLine("Type 6 digit number: ");
            //int num = Numcheck();

            //int newnum = (8 * 1000000 + num) * 10 + 8;
            //Console.WriteLine($"Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir.: {newnum}");



            //int numfirst4 = newnum / 10000;
            //int numsecond4 = newnum % 10000;

            //int nummix = (numsecond4 * 10000) + numfirst4;


            //Console.WriteLine($"Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish: {nummix}");


            //int reverse = 0;
            //int numix1 = nummix;
            //int count = 0;
            //while (numix1 > 0)

            //{
            //    int number = numix1 % 10;

            //    numix1 = numix1 / 10;
            //    reverse = reverse * 10 + number;



            //}

            //Console.WriteLine(reverse);

            //numix1 = reverse;


            Console.WriteLine("Type your 6 digit number");
            int number = Numcheck();

            number = number * 10 + 80000008;
            Console.WriteLine("Typed 8 in the beginnig and end of the value and got new vaue {0}", number);
            Console.WriteLine(" Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish");
            int number1 = number % 10000;
            number1 = number1 * 10000 + number / 10000;
            Console.WriteLine("Result: {0}", number1);
            Console.WriteLine(" Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.Example:  {0,1,2,3,4,5,6,7} Change digit in 1,3,5,7 to 0 ");


            int count = 0;
            int remainder;
            number = 0;
            while (number1 > 0)
            {
                remainder = number1 % 10;
                number1 /= 10;
                number = number * 10 + remainder;
            }
            number1 = number;
            number = 0;
            while (number1 > 0)
            {
                remainder = number1 % 10;
                number1 /= 10;
                if (count % 2 == 0)
                {
                    number = number * 10 + remainder;
                }
                else
                {
                    number = number * 10 + 0;

                }
                count++;
            }
            Console.WriteLine("The Final Result {0}", number);











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
