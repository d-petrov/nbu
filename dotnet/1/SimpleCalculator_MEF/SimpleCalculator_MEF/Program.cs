using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_MEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Composition composition = new Composition();
            String s = "";

            Console.WriteLine("Enter:(exit to exit)");

            while (true)
            {
                s = Console.ReadLine().ToLowerInvariant();

                if (s.Equals("exit"))
                {
                    break;
                }

                Console.WriteLine(composition.calculator.Calculate(s));
            }
        }
    }
}
