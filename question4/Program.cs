
using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("ab");
                }
                Console.WriteLine('a');
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine('b');
            }
            else
            {
                Console.WriteLine(i);
            }

        }
    }
}
