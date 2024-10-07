using System;

namespace NewDay_DiamondKata
{
    public class DiamondKata
    {
        public static void Main(string[] args)
        {
            char inputChar = GetValidInput();
            PrintDiamond(inputChar);

            Console.Write("Press any key...");
            Console.ReadKey();
        }

        /// <summary>
        /// Method to get valid input from the user
        /// </summary>
        /// <returns></returns>
        public static char GetValidInput()
        {
            char inputChar = default;

            bool validInput = false;

            // Keep asking for input until the user enters a valid letter (A-Z)
            while (!validInput)
            {
                Console.Write("Enter an uppercase letter (A-Z): ");
                inputChar = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                // Check if the input is a valid alphabetical letter
                if (inputChar >= 'A' && inputChar <= 'Z')
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid uppercase character (A-Z).");
                }
            }

            return inputChar;
        }

        /// <summary>
        /// Method to print the diamond
        /// </summary>
        /// <param name="inputChar">The middle character in the diamond</param>
        public static void PrintDiamond(char inputChar)
        {
            int size = inputChar - 'A';

            // Loop through each row of the diamond (first half and middle)
            for (int i = 0; i <= size; i++)
            {
                PrintDiamondLine(i, size);
            }

            // Loop through each row of the diamond (second half, in reverse)
            for (int i = size - 1; i >= 0; i--)
            {
                PrintDiamondLine(i, size);
            }
        }

        /// <summary>
        /// Helper method to print each line of the diamond
        /// </summary>
        /// <param name="currentRow">The current row being printed</param>
        /// <param name="totalRows">The total number of rows</param>
        public static void PrintDiamondLine(int currentRow, int totalRows)
        {
            char currentChar = (char)('A' + currentRow);

            // Print leading spaces
            for (int i = 0; i < totalRows - currentRow; i++)
            {
                Console.Write(" ");
            }

            // Print the character for the current row
            Console.Write(currentChar);

            // Print spaces between the characters if it's not the first row (A)
            if (currentRow > 0)
            {
                for (int i = 0; i < 2 * currentRow - 1; i++)
                {
                    Console.Write(" ");
                }

                // Print the same character again at the end of the row
                Console.Write(currentChar);
            }

            // Move to the next line
            Console.WriteLine();
        }
    }
}