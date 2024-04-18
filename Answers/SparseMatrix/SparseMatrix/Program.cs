using System;

namespace SparseMatrix
{
 internal class Program
 {
  static void Main(string[] args)
  {
   /*functions:
    * spars
    * Transpos
    * Set   just work for spars that doesnt have duplicate numbers...
   */
   SparseMat sparseMat = new SparseMat();
   //--------------------------Spars

   int[,] Matris = { { 1, 2, 3 }, { 0, 2, 3 }, { 4, 5, 6 } };
   for (int i = 0; i < sparseMat.Spars(Matris).GetLength(0); i++)
   {

    Console.Write(sparseMat.Spars(Matris).GetValue(i, 0));
    Console.Write(sparseMat.Spars(Matris).GetValue(i, 1));
    Console.Write(sparseMat.Spars(Matris).GetValue(i, 2));
    Console.WriteLine();

   }
   //---------------------------Transpose
   int[,] spars = { { 1, 2, 3 }, { 2, 3, 4 }, { 5, 6, 7 } };
   //or you can us spars function that write previos part
   for (int i = 0; i < sparseMat.Transpose(spars).GetLength(0); i++)
   {
    Console.Write(sparseMat.Transpose(spars).GetValue(i, 0));
    Console.Write(sparseMat.Transpose(spars).GetValue(i, 1));
    Console.Write(sparseMat.Transpose(spars).GetValue(i, 2));
    Console.WriteLine();
   }
   //---------------------------Set


   int[,] spars1 = { { 1, 3, 4 }, { 2, 4, 5 }, { 3, 5, 6 }, { 4, 6, 7 } };
   for (int i = 0; i < spars.GetLength(0); i++)
   {
    Console.Write(sparseMat.Set(spars1, 4, 6, 1).GetValue(i, 0));
    Console.Write(sparseMat.Set(spars1, 4, 6, 1).GetValue(i, 1));
    Console.Write(sparseMat.Set(spars1, 4, 6, 1).GetValue(i, 2));
    Console.WriteLine();
   }

   Console.ReadKey();
  }
 }
}
