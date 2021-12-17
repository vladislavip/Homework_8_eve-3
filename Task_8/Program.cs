using System;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) SWITCH operatoru ile yoxla.
            //Verilmish ededdin sonuncu reqemi
            //1 olarsa - "I gun" sozunu
            //2 olarsa - "II gun" sozunu...
            //7 olarsa - "VI gun" sozunu yaz


            Console.WriteLine("Write the figure for coresponding week day");

            int num = Numcheck();


            switch (num)
                {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Satuday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
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
