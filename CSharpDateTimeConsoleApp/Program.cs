using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDateTimeConsoleApp

   //    IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
  //1. Prints the current date and time to the console.
 //2. Asks the user for a number.
//3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.


{
    class Program
    {
        static void Main(string[] args)
        {
            Retry:
            try
            {
                Console.Write("Welcome To The Time Traveler Application!\n\n" +
                   "I'll add (or remove) hours to the current time!\n\n" + "It's currently: " + DateTime.Now +
                   "\nHow many hours would you like to add / remove? ");

                double userInput = Convert.ToInt32(Console.ReadLine());

                DateTime FutureTime = DateTime.Now.AddHours(userInput);

                Console.WriteLine("\n\nIn {0}hrs it will be {1}!", userInput, FutureTime + "\n\nThanks for demoing my application, press enter to exit!");
                Console.ReadLine();
            }
            catch (OverflowException) 
            {
                Console.WriteLine("\n\nI'm sorry but that is not a valid input.\nPress enter to retry!");
                Console.ReadLine();
                goto Retry;
            }

        }
    }
}
