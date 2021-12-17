using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //1) verilmish ededin tek ve ya cut eded oldugunu yoxla


        Step1:
            Console.WriteLine("Type your number ");
            int num;

            try
            {
                 num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("Zero is not permited"); 
                    goto Step1;
                }
            }

            catch

            {
                Console.WriteLine("Use only numbers");

                goto Step1;

            }


            if (num %2 == 0)

            {

                Console.WriteLine("Your number is Even");
            }

            else

            {

                Console.WriteLine("Your number is odd");
            }
         
            
           
        }
    }
}
