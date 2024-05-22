using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tutorial_week2;

class Program
{
    static void Main(string[] args)
    {
        // Declares an array of 10 integers
        int[] numbers= new int[10];

        IntegerFacts(numbers);
        CaculateArray(out int max_value, out int min_value, out int sum_value, out double average_value,numbers);
        Console.WriteLine("highest value is {0}, lowest value is {1}, sum of the value is {2}, average of the value is {3}", max_value, min_value, sum_value, average_value);
    }

    private static void IntegerFacts(params int[] numbers)
    {
        // fill the array with any number values up to 10 or untill sentinel value entered
        // If an entry is not an integer , re-prompt the user

        for (int i = 0; i < numbers.Length; i++)
        {
            int STOP = 999;
            int number;
            string entryString;

            Console.WriteLine("Enter any number 1 to 10");
            entryString = Console.ReadLine();

            int.TryParse(entryString, out number);
  
            while (number == 0)
            {
                Console.WriteLine("Please enter the vaild number 1 to 10");
                entryString = Console.ReadLine();
                int.TryParse(entryString, out number);
            }
            if (number == STOP) return;
            numbers[i] = number;
            
        }        
    }


    // Call a second method that accepts out parameters highest value, lowest value, sum of the value, artimetic average
    private static void CaculateArray(out int max_value, out int min_value, out int sum_value, out double average_value, params int[] numbers) {

        max_value = numbers[0];
        min_value = numbers[0];
        sum_value = 0;

        for (int i = 0; i < numbers.Length; i++) {
            if (max_value < numbers[i]) {
                max_value = numbers[i];    
            }
            if (min_value > numbers[i])
            {
                min_value = numbers[i];
            }
            sum_value = sum_value + numbers[i];
        }
        average_value = sum_value / numbers.Length;

    }

}


