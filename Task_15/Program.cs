﻿using System;

namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //15) IF operatoru ile yoxla.
            //Verilmish ededdin 1 - ile 365 arasinda olugunu yoxla(1 ve 365 ozude daxil olmaq sherti ile)
            //Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster

            Console.WriteLine("Type your day (1-365): ");

            int day = Numcheck();
       

            if (day <= 31)
            {
                Console.WriteLine("January");
                if (day > 0 && day < 20) { Console.WriteLine("Capricon"); }
                else
                {
                    Console.WriteLine("Aquarius");
                }
            }
            else if (day <= 59)
            {
                Console.WriteLine("February");
                if (day < 50) { Console.WriteLine("Aquarius"); }
                else { Console.WriteLine("Pisces"); }

            }
            else if (day <= 90)
            {
                Console.WriteLine("March");
                if (day < 80) { Console.WriteLine("Pisces"); }
                else { Console.WriteLine("Aries"); }

            }
            else if (day <= 120)
            {
                Console.WriteLine("April");
                if (day < 110) { Console.WriteLine("Aries"); }
                else { Console.WriteLine("Taurus"); }

            }
            else if (day <= 151)
            {
                Console.WriteLine("May");
                if (day < 141) { Console.WriteLine("Taurus"); }
                else { Console.WriteLine("Gemini"); }

            }
            else if (day <= 181)
            {
                Console.WriteLine("June");
                if (day < 171) { Console.WriteLine("Gemini"); }
                else { Console.WriteLine("Cancer"); }

            }
            else if (day <= 212)
            {
                Console.WriteLine("July");
                if (day < 202) { Console.WriteLine("Cancer"); }
                else { Console.WriteLine("Leo"); }

            }
            else if (day <= 243)
            {
                Console.WriteLine("August");
                if (day < 233) { Console.WriteLine("Leo"); }
                else { Console.WriteLine("Virgo"); }

            }
            else if (day <= 273)
            {
                Console.WriteLine("September");
                if (day < 263) { Console.WriteLine("Virgo"); }
                else { Console.WriteLine("Libra"); }

            }
            else if (day <= 304)
            {
                Console.WriteLine("OCtober");
                if (day < 294) { Console.WriteLine("Libra"); }
                else { Console.WriteLine("Scorpio"); }

            }
            else if (day <= 334)
            {
                Console.WriteLine("November");
                if (day < 324) { Console.WriteLine("Scorpio"); }
                else { Console.WriteLine("Sagitarius"); }

            }
            else if (day <= 365)
            {
                Console.WriteLine("December");
                if (day < 355) { Console.WriteLine("Sagitatrius"); }
                else { Console.WriteLine("Capricon"); }

            }


        }
        public static int Numcheck()

        {

        step1:
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num < 366)
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
