using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SortMatrix
    {
        /// <summary>
        /// Sort a matrix of integers
        /// </summary>
        /// <param name="matrix">Sortable jagged array</param>
        /// <param name="methodSorting">Sort method of the matrix</param>
        /// <param name="typeSort">Type of sort</param>
        public static void Sorting(int[][] matrix, Func<int[], int[], TypeSort> methodSorting, TypeSort typeSort)
        {
            if (matrix == null)
                throw new ArgumentNullException();

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    if (methodSorting(matrix[i], matrix[j]) == typeSort)
                    {
                        Swap(matrix, i, j);
                    }
                }
            }
        }

        /// <summary>
        /// Swaps the elements of the array
        /// </summary>
        /// <param name="matrix">Sortable jagged array</param>
        /// <param name="numberString1"></param>
        /// <param name="numberString2"></param>
        private static void Swap(int[][] matrix, int numberString1, int numberString2)
        {
            int[] temp = matrix[numberString1];
            matrix[numberString1] = matrix[numberString2];
            matrix[numberString2] = temp;
        }
    }
}
