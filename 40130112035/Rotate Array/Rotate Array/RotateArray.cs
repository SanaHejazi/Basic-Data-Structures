using System;

namespace Rotate_Array
{
 public class RotateArray
 {
  public static void Rotate(int[] A, int k)
  {
   int[] result = new int[A.Length];
   for (int i = 0; i < A.Length; i++)
   {
    if (i + k > A.Length - 1)
    {
     int index = A.Length - i - 1;
     result[index] = A[i];
    }
    else
    {
     result[i + k] = A[i];
    }

   }
   Console.Write("{");
   for (int i = 0; i < result.Length; i++)
   {
    Console.Write($"{result[i]} ");
   }
   Console.Write("}");

  }
 }
}
