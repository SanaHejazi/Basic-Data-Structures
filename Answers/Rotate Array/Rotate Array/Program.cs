﻿using System;

namespace Rotate_Array
{
 internal class Program
 {
  static void Main(string[] args)
  {

   int[] A = { 1, 2, 3, 4, 5 };
   RotateArray rotateArray = new RotateArray();
   rotateArray.Rotate(A, 2);
   Console.ReadKey();
  }
 }
}
