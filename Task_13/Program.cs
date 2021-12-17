using System;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) Verilmish 7 reqemli eded polindromdursa o zaman onun daxilnde nece dene 0 reqemi oldugunu tap ?

            Console.WriteLine("Type your 7 digit number");

            int number = Numcheck();

            int reverse = 0;

            int numberforwhile;

            numberforwhile = number;

         
          while (numberforwhile > 0)

            {
                int remover = numberforwhile % 10;

                reverse =reverse * 10 + remover; 

                numberforwhile = numberforwhile / 10;
                

                

            }

          if (number==reverse)

            {

                Console.WriteLine( $"your number {number} is polindromus");

                int counter = 0;

                while (number>0)
                {

                   int reminant  = number % 10;

                    if (reminant ==0)

                    {
                      
                        counter++;
                    }
                    

                    number = number / 10;
                }
                Console.WriteLine($"your number has {counter} zeros");


            }
          else
            {
                Console.WriteLine($"your number {number} is not polindromus");

            }

            









        static int Numcheck()

            {

            step1:
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 999999 && num < 10000000)
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
}
