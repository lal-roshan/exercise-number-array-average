using System;
using System.Linq;

namespace NumberAverage
{
	public class NumberAverage
	{
		public static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter the number of values: ");
				// get size of array
				int length = System.Convert.ToInt32(Console.ReadLine());
				// declare array for the given size
				int[] numbers = new int[length];
				
				//get the values of the array from the user
				Console.WriteLine("Enter the values:");
				string[] numberString = Console.ReadLine().Split(' ');
				for(int i=0; i<length; i++){
					numbers[i] = System.Convert.ToInt32(numberString[i]);
				}
				
				//call FindAverage() method to calculate average and receive string response
				string result = FindAverage(numbers);
				//print the result
				Console.WriteLine();
				Console.WriteLine(result);
			}
			catch (Exception err)
			{
				Console.WriteLine(err.Message);
			}
		}

		//write here logic to calculate the average an array
		public static String FindAverage(int[] numbers)
		{
			string result = "";
			//Check whether array is empty
			if(numbers.Length == 0){
				result = "Array cannot be empty";
			}
			//Check whether all numbers are positive
			else if(numbers.Any(x => x < 0)){
				result = "Give proper positive integer values";
			}
			//Calculate average
			else{
				int total = 0;
				foreach(int number in numbers){
					total += number;
				}
				result = "The average value is: " + (total/(numbers.Length));
			}
			return result;
		}
	}
}