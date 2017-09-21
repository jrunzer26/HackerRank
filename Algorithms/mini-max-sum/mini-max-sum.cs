using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	static void Main(String[] args) {
	    string[] arr_temp = Console.ReadLine().Split(' ');
	    int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
		long maxNumberIndex, minNumberIndex;
		minNumberIndex = 0;
		maxNumberIndex = 0;
		for (int i = 0; i < arr.Length; i++) {
			if (arr[i] < arr[minNumberIndex]) {
				minNumberIndex = i;
			} else if (arr[i] > arr[maxNumberIndex]) {
				maxNumberIndex = i;
			}
		}
		long minSum, maxSum;
		minSum = 0;
	   	maxSum = 0;
		for (int i = 0; i < arr.Length; i++) {
			if (!(i == minNumberIndex)) {
				maxSum += arr[i];
			}
			if (!(i == maxNumberIndex)) {
				minSum += arr[i];
			}
		}
		Console.WriteLine(minSum + " " + maxSum);
	}
}
