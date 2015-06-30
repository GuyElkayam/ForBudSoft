using System;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            BudSoftMethod();
        }

        static void BudSoftMethod()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    if (i%5==0)
                    {
                        Console.WriteLine("BudSoft");
                    }
                    else
                    {
                        Console.WriteLine("Bud");
                    }
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Soft");
                }
            }
        }
    }
}
