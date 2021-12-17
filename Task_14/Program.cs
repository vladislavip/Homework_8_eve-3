using System;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler(bu o demekdirki 1, 2, 3, 4, 5, 6, 7 reqemlide ola biler)
            //Bu ededin evvelin 1 reqemini artir.

            Console.WriteLine("Type your number (maximum 8 digit): ");

            int num = Numcheck();

            int num1 = num;

            int counter = 0;

            while (num1>0)

            {
                num1 = num1 / 10;
                counter++;
            }


    


            int i = 1;
            while (counter>0)

            {
                i = 10 * i;

                counter--;
            }

    

            int finaldigit = i + num;

            Console.WriteLine($"Bu ededin evvelin 1 reqemini artir.{finaldigit}");



        }

        public static int Numcheck()

        {

        step1:
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num < 100000000)
                {
                    
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
