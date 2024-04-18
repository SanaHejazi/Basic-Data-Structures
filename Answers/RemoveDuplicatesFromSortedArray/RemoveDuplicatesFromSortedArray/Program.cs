using System;

namespace RemoveDuplicatesFromSortedArray
{
 internal class Program
 {
  static void Main(string[] args)
  {
   int[] A = { 1, 2, 2, 2, 2, 4, 4, 4, 5 };
   RemoveDup removeDup = new RemoveDup();
   removeDup.Remove(A);
   Console.ReadKey();
  }
 }
}
