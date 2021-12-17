using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana



            Console.WriteLine("Type yor number");

            int num = Numcheck();


            if (num%10 ==7)

            {

                Console.WriteLine("Your number ending with 7");


            }
            else
            {
                Console.WriteLine($"Your number ending with {num%10}");
            }

            int Numcheck()

            {

            step1:
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    //if (num.GetType() == typeof(int))

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
