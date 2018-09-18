using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    /*
    Given two even arrays of equal size, interleave its elements
    */

    public class ArrayInterleave
    {
        public void Interleave(int[] array1, int[] array2)
        {
            for (int bottom = 1, top = array2.Length - 1; bottom < array1.Length && top > -1; bottom++, top--)
            {
                for (int index1 = bottom, index2 = 0; index1 < array1.Length && index2 < top; index1++, index2++)
                {
                    int aux = array1[index1];
                    array1[index1] = array2[index2];
                    array2[index2] = aux;
                }
            }
        }
    }
}
