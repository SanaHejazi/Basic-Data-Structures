namespace Maximum_Subarray_Sum
{
 public class MaxSub
 {
  public static int MaxSum(int[] A)
  {
   int Sum = 0;
   int Currentmax = int.MinValue;

   for (int i = 0; i < A.Length; i++)
   {
    Sum = Sum + A[i];
    if (Sum > Currentmax)
    {
     Currentmax = Sum;
    }
    if (Sum < 0)
    {
     Sum = 0;
    }

   }

   return Currentmax;
  }

 }
}
