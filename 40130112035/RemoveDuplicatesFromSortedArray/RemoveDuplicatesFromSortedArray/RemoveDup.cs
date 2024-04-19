using System;
using System.Linq;

namespace RemoveDuplicatesFromSortedArray
{
 internal class RemoveDup
 {
  public static void Remove(int[] A)
  {
   for (int i = 0; i + 1 < A.Length; i++)
   {
    if (A[i] == A[i + 1])
    {
     var B = A.ToList();
     B.RemoveAt(i + 1);
     A = B.ToArray();
     i = i - 1;
    }
   }
   Console.WriteLine(A.Length);

  }
 }
}
