using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        // Initializing the variable that will change throughout the code.
        float answer = 0;
        float value1 = 0;
        float value2 = 0;

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
        /// Asks the user to enter a number for the equation.
        /// </summary>
        /// <returns></returns>
        float AskNumber()
        {
            string input = "";
            float number = 0;
            bool validInputRecieved = false;
            while (validInputRecieved == false)
            {
                Console.Write("Please enter a number \n> ");
                input = Console.ReadLine();
                if (!float.TryParse(input, out number))
                {
                    Console.WriteLine("Please enter a vaild input.");
                    ClearScreen();
                }
                else
                {
                    float.TryParse(input, out number);
                    validInputRecieved = true;
                }
            }

            return number;
        }

        /// <summary>
        /// Asks the user to input the operator for the equation.
        /// </summary>
        /// <returns></returns>
        string AskOperator()
        {
            string input = "";
            bool validInputRecieved = false;

            while(validInputRecieved == false)
            {
                Console.Write("Please enter an operator \n> ");
                input = Console.ReadLine();
                if(!(input == "+" || input == "-" || input == "*" || input == "/"))
                {
                    Console.WriteLine("Please enter a valid input.");
                    ClearScreen();
                }
                else
                {
                    validInputRecieved = true;
                }
            }

            return input;
        }

        /// <summary>
        /// Asks the user to enter two numbers and an operator, then finds the solution.
        /// </summary>
        void AskUser()
        {
            string sign = "";
            // Sets the number for value1. If answer, which value1 is equal to initially is 0, ask the user
            // for a number.
            value1 = AskNumber();
            ClearScreen();
            
            // Sets the sign for the operation.
            sign = AskOperator();
            ClearScreen();

            // Sets the number for value2.
            value2 = AskNumber();
            ClearScreen();

            // Checks what the sign is, and sets answer equal to the appropriate equation.
            if(sign == "+")
            {
                answer = Add(value1, value2);
            }
            else if (sign == "-")
            {
                answer = Subtract(value1, value2);
            }
            else if (sign == "*")
            {
                answer = Multiply(value1, value2);
            }
            else
            {
                answer = Divide(value1, value2);
            }

            Console.WriteLine(value1 + " " + sign + " " + value2 + " = " + answer);
        }

        public void Run()
        {
            bool isFinished = false;
            string input = "";

            // This program will continue to run until the user is finished.
            while (!isFinished)
            {
                Console.Write("Press 0 to quit. \nPress any other key to continue. \n> ");
                input = Console.ReadLine();
                Console.Clear();

                //This option will end the program.
                if(input == "0")
                {
                    isFinished = true;
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
