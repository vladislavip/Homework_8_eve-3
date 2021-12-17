using System;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) SWITCH operatoru ile yoxla.
            //Verilmish ededdin 1 - ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
            //Eger bu eded
            //1 olarsa - "Yanvar" sozunu
            //2 olarsa - "Fevral" sozunu...
            //12 olarsa - "Dekabr" sozunu yaz


            Console.WriteLine("Write the figure for coresponding week day");

            int num = Numcheck();

            switch (num)
            {
                case 1:
                    Console.WriteLine("January ");
                    break;

                case 2:
                    Console.WriteLine("February ");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May ");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October ");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;


                default:
                    Console.WriteLine("Wrong number");
                    break;
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
