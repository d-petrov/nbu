using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_MEF
{
    class Program
    {
        internal static Char FindFirstNonDigit(String input)
        {
            foreach(char c in input)
            {
                if(!string.IsNullOrWhiteSpace(c.ToString()) && !Char.IsDigit(c))
                {
                    return c;
                }
            }
            return String.Empty.ToCharArray()[0];
        }

        internal static Operation ParseCommand(String command)
        {
            Char symbol = FindFirstNonDigit(command);
            Operation op = new Operation();

            if (string.IsNullOrEmpty(symbol.ToString()))
            {
                return op;
            }

            int left = 0;
            int right = 0;
            try
            {
                left = int.Parse(command.Substring(0, command.IndexOf(symbol)));
                right = int.Parse(command.Substring(command.IndexOf(symbol) + 1, 1));
            }
            catch (Exception)
            {
                return op;
            }

            op.Valid = true;
            op.Symbol = symbol;
            op.Left = left;
            op.Right = right;

            return op;
        }

        static void Main(string[] args)
        {
            Composition composition = new Composition();
            String s = "";

            while (true)
            {
                Console.WriteLine("Enter:(exit to exit)");
                Operation op = null;
                
                s = Console.ReadLine().ToLowerInvariant();

                if (s.Equals("exit"))
                {
                    break;
                }

                op = ParseCommand(s);
                Console.WriteLine($"left:{op.Left}, right:{op.Right}, symbol:{op.Symbol}");

                Console.WriteLine(composition.calculator.Calculate(s,op));
            }
        }
    }
}
