using System;

namespace Lab16
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Give me prime number");
            int num1 = Int32.Parse(Console.ReadLine());
            if (num1 < 2)
            {
                Console.WriteLine("Not a Prime");
                Main();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine("Not a Prime");
                        Main();
                    }
                }
            }
        }

    }
}
