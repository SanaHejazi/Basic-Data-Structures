namespace Find_The_Missing_Number
{
 public class FindMissing
 {
  public int FindMissingNumber(int[] A)
  {

   int minIndex = 0;
   for (int i = 1; i < A.Length; i++)
   {
    if (A[i] < A[minIndex])
    {
     minIndex = i;
    }
   }
   if (A[minIndex] != 0)
   {
    return 0;
   }
   else
   {
    int nextVal = A[minIndex] + 1;
    bool check;
    do
    {
     check = false;
     for (int i = 0; i < A.Length; i++)
     {
      if (A[i] == nextVal) { check = true; }
     }
     nextVal = nextVal + 1;
    }
    while (check == true);

    return nextVal - 1;
   }

  }
 }
}

