using System;

namespace BalancedBracketsNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(BalancedBrackets.HasBalancedBrackets("[test]"));        
            Console.WriteLine(BalancedBrackets.HasBalancedBrackets("[test"));

        }
    }
}
