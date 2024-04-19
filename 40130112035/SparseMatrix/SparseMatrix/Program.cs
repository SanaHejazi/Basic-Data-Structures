using System;

namespace SparseMatrix
{
 internal class Program
 {
  static void Main(string[] args)
  {
   //Note: Comment other Test Functions And run test Function you want...



   /*functions:
    * spars
    * Transpos
    * Set   
   */





   //--------------------------Spars Test

   int[,] Matris1 = { { 1, 2, 3 }, { 0, 2, 3 }, { 4, 5, 6 } };
   for (int i = 0; i < SparseMat.Spars(Matris1).GetLength(0); i++)
   {

    Console.Write(SparseMat.Spars(Matris1).GetValue(i, 0));
    Console.Write(SparseMat.Spars(Matris1).GetValue(i, 1));
    Console.Write(SparseMat.Spars(Matris1).GetValue(i, 2));
    Console.WriteLine();

   }

   //---------------------------Transpose Test

   int[,] spars = { { 1, 2, 3 }, { 2, 3, 4 }, { 5, 6, 7 } };

   for (int i = 0; i < SparseMat.Transpose(spars).GetLength(0); i++)
   {
    Console.Write(SparseMat.Transpose(spars).GetValue(i, 0));
    Console.Write(SparseMat.Transpose(spars).GetValue(i, 1));
    Console.Write(SparseMat.Transpose(spars).GetValue(i, 2));
    Console.WriteLine();
   }


   //-------------or you can us spars function that write previos part Like:
   int[,] Matris = { { 1, 0, 0, }, { 0, 0, 5 }, { 6, 7, 8 } };

   //You Have to covert SystemArray to Int[,] with Help Of "as int[,]" Code

   for (int i = 0; i < SparseMat.Transpose((SparseMat.Spars(Matris) as int[,])).GetLength(0); i++)
   {
    Console.Write(SparseMat.Transpose((SparseMat.Spars(Matris) as int[,])).GetValue(i, 0));
    Console.Write(SparseMat.Transpose((SparseMat.Spars(Matris) as int[,])).GetValue(i, 1));
    Console.Write(SparseMat.Transpose((SparseMat.Spars(Matris) as int[,])).GetValue(i, 2));
    Console.WriteLine();
   }

   //---------------------------Set Test


   int[,] spars1 = { { 1, 3, 4 }, { 2, 4, 5 }, { 4, 5, 6 }, { 4, 6, 7 } };
   for (int i = 0; i < spars1.GetLength(0); i++)
   {
    Console.Write(SparseMat.Set(spars1, 4, 5, 1).GetValue(i, 0));
    Console.Write(SparseMat.Set(spars1, 4, 5, 1).GetValue(i, 1));
    Console.Write(SparseMat.Set(spars1, 4, 5, 1).GetValue(i, 2));
    Console.WriteLine();
   }


   //----------------------------------------------------------------------



   Console.ReadKey();
  }
 }
}
