﻿using System;

namespace MergeSortedArray
{
 internal class Program
 {
  static void Main(string[] args)
  {
   int[] A = { 1, 2, 4, 5 };
   int[] B = { 5, 6 };
   MergeSorted mergeSorted = new MergeSorted();
   mergeSorted.Merge(A, B);
   Console.ReadKey();
  }
 }
}
