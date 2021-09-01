using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        // Initializing the variable that will change throughout the code.
        float value = 0;

        /// <summary>
        /// This code takes the main value and displays it to the user.
        /// </summary>
        void DisplayValue()
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// This function clears the screen to keep it from getting cluttered with information.
        /// </summary>
        void ClearScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Finds the sum of two given numbers.
        /// </summary>
        /// <param name="number1"> The first number. </param>
        /// <param name="number2"> The second number. </param>
        /// <returns> The sum of the two numbers. </returns>
        float Add(float number1, float number2)
        {
            return number1 + number2;
        }

        /// <summary>
        /// Finds the difference between two given numbers.
        /// </summary>
        /// <param name="number1"> The first number.</param>
        /// <param name="number2"> The second number. </param>
        /// <returns> The difference between the two numbers. </returns>
        float Subtract(float number1, float number2)
        {
            return number1 - number2;
        }

        /// <summary>
        /// Finds the answer to the first number multiplied by the second.
        /// </summary>
        /// <param name="number1"> The first number. </param>
        /// <param name="number2"> The second number. </param>
        /// <returns> The multiplication of one number by another. </returns>
        float Multiply(float number1, float number2)
        {
            return number1 * number2;
        }

        /// <summary>
        /// Finds the answer to the division of the first number and the second.
        /// </summary>
        /// <param name="number1"> The first number. </param>
        /// <param name="number2"> The second number. </param>
        /// <returns> The division of one number by another. </returns>
        float Divide(float number1, float number2)
        {
            return number1 / number2;
        }

        /// <summary>
        /// Asks the user what they would like to do with the main value, adding to it, subtracting
        /// from it, multiplying by it, or dividing by it.
        /// </summary>
        /// <param name="value"> This is the main value that the user can change. </param>
        /// <returns> Returns the main value of the program. Now modified by the user. </returns>
        void AskUser()
        {
            string input = "";
            bool validInputRecieved = false;
            bool validNumberRecieved = false;
            float number = 0;

            // This will ask the user what they would like to do to modify the value. It will continue to ask
            // until the user gives a valid input.
            while (validInputRecieved == false)
            {
                DisplayValue();
                Console.WriteLine("What would you like to do with the value?");
                Console.Write("1. Add \n2. Subtract \n3. Multiply \n4. Divide \n> ");
                input = Console.ReadLine().ToLower();

                // This option will add input to value if it is a valid number.
                if(input == "1" || input == "add")
                {
                    while (validNumberRecieved == false)
                    {
                        ClearScreen();
                        DisplayValue();
                        Console.Write("Type in a number to add to the value. \n> ");
                        input = Console.ReadLine();
                        if(float.TryParse(input, out number))
                        {
                            float.TryParse(input, out number);
                            value = Add(value, number);
                            validNumberRecieved = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input.");
                        }
                    }
                    validInputRecieved = true;
                }

                // This option will subtract input from value if it is a valid number.
                else if (input == "2" || input == "subtract")
                {
                    while (validNumberRecieved == false)
                    {
                        ClearScreen();
                        DisplayValue();
                        Console.Write("Type in a number to subtract from the value. \n> ");
                        input = Console.ReadLine();
                        if (float.TryParse(input, out number))
                        {
                            float.TryParse(input, out number);
                            value = Subtract(value, number);
                            validNumberRecieved = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input.");
                        }
                    }
                    validInputRecieved = true;
                }

                // This option will multiply input by value if it is a valid number.
                else if (input == "3" || input == "multiply")
                {
                    while (validNumberRecieved == false)
                    {
                        ClearScreen();
                        DisplayValue();
                        Console.Write("Type in a number to multiply by the value. \n> ");
                        input = Console.ReadLine();
                        if (float.TryParse(input, out number))
                        {
                            float.TryParse(input, out number);
                            value = Multiply(value, number);
                            validNumberRecieved = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input.");
                        }
                    }
                    validInputRecieved = true;
                }

                // This option will divide input by value if it is a valid number.
                else if (input == "4" || input == "divide")
                {
                    while (validNumberRecieved == false)
                    {
                        ClearScreen();
                        DisplayValue();
                        Console.Write("Type in a number to divide by the value. \n> ");
                        input = Console.ReadLine();
                        if (float.TryParse(input, out number))
                        {
                            float.TryParse(input, out number);
                            value = Divide(value, number);
                            validNumberRecieved = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input.");
                        }
                    }
                    validInputRecieved = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input.");
                    ClearScreen();
                }
            }

            ClearScreen();
        }

        public void Run()
        {
            bool isFinished = false;
            string input = "";

            // This program will continue to run until the user is finished.
            while (isFinished == false)
            {
                DisplayValue();
                Console.Write("Press 0 to quit. \nPress 1 to reset value. \nPress any other key to" +
                    " continue. \n> ");
                input = Console.ReadLine();
                Console.WriteLine();

                //This option will end the program.
                if(input == "0")
                {
                    isFinished = true;
                }

                // This option will reset the value to 0, then continue asking the user to modify it.
                else if(input == "!")
                {
                    value = 0;
                    AskUser();
                    ClearScreen();
                }

                // This option will just ask the user to modify the value.
                else
                {
                    AskUser();
                    ClearScreen();
                }
            }
        }
    }
}
