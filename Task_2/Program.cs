using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //2) 2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart.
        //Eks halda "bolunmur" sozunu cap et

       
            Console.WriteLine("Type your First number ");


            int num1 = Numcheck();

            

            Console.WriteLine("Type your Second number ");


            int num2 = Numcheck();


            if (num2 == 0)

            {
                throw new Exception("second number should not be 0");
                    }

            if (num1 % num2 == 0 )

            {
                Console.WriteLine(  num1/num2);
            
            }

            else

            {

                Console.WriteLine("Numbers are indivisible ");
            }



            int Numcheck()

            {

            step1:
                try
                {
                    int num=Convert.ToInt32(Console.ReadLine());
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
