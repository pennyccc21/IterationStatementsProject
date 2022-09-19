using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO 

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var myNumber = 0;



            // Create a do-while loop and use the template below:

            {
                // Increment num by 1

                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(/* num */);

            } // <---- While your variable is less than 100

            {
                myNumber++; // 100

                numbers.Add(myNumber); // 100

            } while (myNumber < 100) ;



            // Create a while loop
            // <--- While num is less than 200
            while (numbers.Count < 200)
            {
                myNumber++;

                numbers.Add(myNumber);
            }




            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
            //In the scope of the foreach loop, print each number in numbers
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }


            // place numbers[i] inside of the Console.WriteLine() method
        }

        //------------End of exercise
    }
}
}