using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //5) Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman
            //hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.
            


            Console.WriteLine("Type your two digit number ");


            int num = Numcheck();

            if ((num % 10)% 2 ==0  && (num / 10) %2==0)


            {

                Console.WriteLine($"Product of first and second digits equal to {(num %10)*(num / 10)} ");

            }
            else
            { 

            if ((num % 10) % 2 != 0)
                {
                    Console.WriteLine("Second number is not even");
                }
               if ((num / 10) % 2 != 0)
                {
                    Console.WriteLine("First number is not even");
                }
           
              


            }

        }



        public static int Numcheck()

        {

        step1:
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 9 && num < 100)
                {
                    Console.WriteLine("Your number is 2 digit");
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
 

