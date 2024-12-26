using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static IEnumerable<int> GetSortedNumbers(
			IEnumerable<int> numbers) {
		return numbers.OrderBy(number => number);
	}

	// Example
	// int[] numbers = { 43, 32, 734, 45 };
	//
	//GetSortedNumbers(numbers)
	//>>>>> output
	//
	//{32, 43, 45, 734}
	
	//Question
	//Make program that takes numbers from user
	//and writes sum numbers and sorted numbers.Program must be by cycle
}
