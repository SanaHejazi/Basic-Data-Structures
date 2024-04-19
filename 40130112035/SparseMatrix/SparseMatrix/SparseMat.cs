using System;

namespace SparseMatrix
{
 internal class SparseMat
 {

  public static Array Spars(int[,] A)
  {
   int index = 0;
   for (int i = 0; i < A.GetLength(0); i++)
   {
    for (int j = 0; j < A.GetLength(1); j++)
    {
     if (A[i, j] != 0)
     {
      index++;
     }
    }
   }
   int count = -1;
   int[] saveval = new int[index];
   int[] saverow = new int[index];
   int[] savecol = new int[index];
   for (int i = 0; i < A.GetLength(0); i++)
   {
    for (int j = 0; j < A.GetLength(1); j++)
    {
     if (A[i, j] != 0)
     {
      count++;
      saveval[count] = A[i, j];
      saverow[count] = i;
      savecol[count] = j;
     }
    }
   }
   int[,] Spars = new int[count + 1, 3];

   for (int i = 0; i <= count; i++)
   {
    Spars[i, 0] = saverow[i];
    Spars[i, 1] = savecol[i];
    Spars[i, 2] = saveval[i];
   }
   return Spars;

  }

  public static Array Transpose(int[,] Spars)
  {
   int[,] Transpose = new int[Spars.GetLength(0), Spars.GetLength(1)];

   for (int i = 0; i < Transpose.GetLength(0); i++)
   {
    Transpose[i, 0] = Spars[i, 1];
    Transpose[i, 1] = Spars[i, 0];
    Transpose[i, 2] = Spars[i, 2];
   }
   return Transpose;
  }

  public static Array Set(int[,] Spars, int row, int col, int newval)
  {
   int Lowrow = 0;
   int Highrow = Spars.GetLength(0) - 1;
   do
   {
    int Avg = (Lowrow + Highrow) / 2;

    if (Spars[Avg, 0] == row && Spars[Avg, 1] == col)
    {
     Spars[Avg, 2] = newval;
     break;
    }
    if ((Spars[Avg, 0] < row || Spars[Avg, 0] == row && Spars[Avg, 1] < col))
    {
     Lowrow = Avg + 1;
    }

    else
    {
     Highrow = Avg - 1;
    }

   } while (Lowrow <= Highrow);

   return Spars;

  }

 }
}
