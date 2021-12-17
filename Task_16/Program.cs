using System;

namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine();


            //16)*Verilmish 6 reqemli ededde nece unikal reqem var ? (UNIKAL - Ededin daxilde her reqemden bir numayende secilecek. Yekunda nece numayende olacaq?)

            Console.WriteLine("Type yout 6 digit number");

            int number = Numcheck();


            int [] arr = new int[0];


            while (number > 0)
            {
                int remainder = number % 10;
                number /= 10;
                if (Array.IndexOf(arr, remainder) == -1)
                {
                    Array.Resize(ref arr, arr.Length + 1);

                    arr[arr.Length - 1] = remainder;

                }
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Array {arr}");
            Console.WriteLine($"Unical numbers {arr.Length}");
        }



        public static int Numcheck()

        {

        step1:
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 99999 && num < 1000000)
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




        
    

