using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string:");
            var input = Console.ReadLine().ToLower();

            // repeat each character plus one based on its position
            var outputString = "";

            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    if (j == 0)
                    {
                        var capitalized = input.ToUpper();
                        outputString += capitalized[i];
                    }
                    else
                        outputString += input[i];
                }
                if (i != input.Length)
                {
                    outputString += "-";
                }
            }
            Console.WriteLine(outputString);
        }
    }
}
