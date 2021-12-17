using System;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) IF operatoru ile yoxla.
            //6 dene eded verilib.Bu ededlerden hansi en boyukdur.
            Console.WriteLine("Type 1st number: ");
            int num1 = Numcheck();

            Console.WriteLine("Type 2nd number: ");
            int num2 = Numcheck();

            Console.WriteLine("Type 3rd number: ");
            int num3 = Numcheck();

            Console.WriteLine("Type 4th number: ");
            int num4 = Numcheck();

            Console.WriteLine("Type 5th number: ");
            int num5 = Numcheck();

            Console.WriteLine("Type 6th number: ");
            int num6 = Numcheck();

            if (num1 > num2 == true)

            {
                Console.WriteLine(num1);

            }
            else
            {
                if (num2 > num3 == true)

                {

                    Console.WriteLine(num2);

                }
                else
                {

                    if (num3 > num4 == true)
                    {
                        Console.WriteLine(num3);
                    }
                    else
                    {
                        if (num4 > num5 == true)

                        {
                            Console.WriteLine(num4);

                        }
                        else
                        {
                            if (num5 > num6 == true)
                            {
                                Console.WriteLine(num5);
                            }
                            else
                            {
                                Console.WriteLine(num6);
                            }


                        }
                    }


                }






            }
        }

        public static int Numcheck()

        {

        step1:
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                
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
