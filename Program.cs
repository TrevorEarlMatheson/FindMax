using System;

namespace FindMax
{
    class Program
    {
        static int GetMaximum()
        {
               int[] numbers = GetArray();
               Array.Sort(numbers); //Sort then reverse the array. Return index 0 since that is now the maximum.
               Array.Reverse(numbers);
               return(numbers[0]);
        }
        
        static int[] GetArray()
        {
            Console.WriteLine("Please enter a string of numbers separated by commas, example: 1,2,3,4,5");
            string userInput = Console.ReadLine().Replace(" ", ""); //Remove white space and save users input.
            try
            {
                int[] numbers = Array.ConvertAll(userInput.Split(','), int.Parse); //Save numbers in array, if not valid entry let user know and ask again.
                return(numbers);
            }
            catch
            {
                Console.WriteLine("This is not a valid entry, please try again.");
                return(GetArray());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The maximum is {0}", GetMaximum());
        }
    }
}
