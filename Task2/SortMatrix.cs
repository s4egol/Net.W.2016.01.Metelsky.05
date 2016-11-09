using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class SortMatrix
    {
        /// <summary>
        /// Sort a matrix of integers
        /// </summary>
        /// <param name="matrix">Sortable matrix</param>
        /// <param name="compare"></param>
        public static void Sorting(int[][] matrix, ICustomComparer compare)
        {
            if (matrix == null || compare == null)
                throw new ArgumentNullException();

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    if (compare.CompareArrays(matrix[i], matrix[j]) > 0)
                    {
                        Swap(ref matrix[i], ref matrix[j]);
                    }
                }
            }
        }

        /// <summary>
        /// Swaps the elements of the array
        /// </summary>
        /// <param name="string1">First string of array</param>
        /// <param name="string2">Second string of array</param>
		private static void Swap(ref int[] string1, ref int[] string2)
        {
            int[] temp = string1;
            string1 = string2;
            string2 = temp;
        }
    }
}
