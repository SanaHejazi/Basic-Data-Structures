using System;

namespace MergeSortedArray
{
 public class MergeSorted
 {
  public static void Merge(int[] A, int[] B)
  {
   int[] result = new int[A.Length + B.Length];
   for (int i = 0; i < A.Length; i++)
   {
    result[i] = A[i];
   }
   int m = A.Length;
   for (int i = 0; i < B.Length; i++)
   {
    result[m] = B[i];
    m = m + 1;
   }

   Console.Write("{");
   for (int i = 0; i < A.Length + B.Length; i++)
   {
    Console.Write($"{result[i]} ");
   }
   Console.Write("}");
  }
 }
}
