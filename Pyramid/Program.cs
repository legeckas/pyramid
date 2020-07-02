using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        private static void GetUserInput()
        {
            Console.WriteLine("Please enter the size of the pyramid: ");
            int pyramidSize;
            string userInput = Console.ReadLine();

            switch (int.TryParse(userInput, out pyramidSize))
            {
                case true:
                    PrintPyramid(pyramidSize);
                    break;
                case false:
                    Console.WriteLine("Please enter a valid pyramid size!"); 
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    GetUserInput();
                    break;
            }
            PrintPyramid(pyramidSize);
        }

        private static void PrintPyramid(int pyramidSize)
        {
            string finalPyramidString = "";

            for (int i = 0; i < pyramidSize + 1; i++)
            {
                string pyramidLevelString = "";

                for (int j = 0; j < i; j++)
                {
                    pyramidLevelString += "*";
                }

                for (int k = pyramidSize - i; k > 0; k--)
                {
                    pyramidLevelString = " " + pyramidLevelString;
                }

                finalPyramidString = finalPyramidString + pyramidLevelString + "\n";
            }

            Console.WriteLine(finalPyramidString);
            Console.ReadLine();
        }
    }
}
