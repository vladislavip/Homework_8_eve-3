using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Verilmihs 2 reqemli ededin reqemleri eynidirmi? Beli ve Xeyr cavabini yaz ekrana

            Console.WriteLine("Type your two digit number ");


            int num = Numcheck();

            if (num%10 ==num/10)


            {



                Console.WriteLine("First and second numbers are equal");
                       
            }
            else
            {
                Console.WriteLine("First abd second digits are not equal");
            }
           

        }



            public static int Numcheck()

            {

            step1:
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                   if (num > 9 && num<100)
                {
                    Console.WriteLine("Your number is 2 digit" );
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
