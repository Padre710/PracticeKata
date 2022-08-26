using System;


//Write a function that takes an integer as input,
//    and returns the number of bits that are equal to one in the binary representation of that number.
//    You can guarantee that input is non-negative.
//Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case



namespace Practice_
{

    public  class Kata

    {
        
        public  static int CountBits(int n)
        {
            int m = 0;
            int i;
            int[] a = new int[100];
            //Console.Write("Enter the number to convert: ");
            //n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            //Console.Write("Binary of the given number= ");
            //int m = 0;
            for (i = i - 1; i >= 0; i--)
            {

                // Console.Write(a[i]);
                if (a[i] != 0)
                {
                    m++;
                  // Console.Write(m);
                   // return m;

                }
                

            }
             Console.Write(m);
             return m;
        }


        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("please input a number here: ");
                int number = int.Parse(Console.ReadLine());

               // Kata kor = new Kata();
                Kata.CountBits(number);



            }
        }

    }
}