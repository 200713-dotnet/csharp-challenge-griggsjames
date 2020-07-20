using System;

namespace Palindrome.Domain
{
    class Program
    {
        static void Main()
        {
            Palindrome();
        }

        static void Palindrome()
        {
            var input = (Console.ReadLine());
            int leftside = 0;
            int rightside = (input.Length -1);

            while(rightside > 1)
            {
                if(input[leftside++] != input[rightside--])
                {
                    Console.WriteLine(" Input given is not a palindrome");
                    return;
                }
            }

            Console.WriteLine(" Input is a Palindrome");
        }
    }
}
