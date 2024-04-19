using System;

namespace Find_The_Missing_Number
{
 internal class Program
 {
  static void Main(string[] args)
  {
   int[] A = { 0, 1, 3, 5, 2 };

   Console.WriteLine(FindMissing.FindMissingNumber(A));
   Console.ReadKey();
  }
 }
}
