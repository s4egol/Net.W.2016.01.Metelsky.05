using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MatrixLogic
    {
        public static TypeSort SortBySumElementsRows(int[] array1, int[] array2)
        {
            if ((array1 == null) || (array2 == null))
                throw new ArgumentNullException();

            if (array1.Sum() > array2.Sum())
                return TypeSort.Ascending;
            else
                return TypeSort.Descending;
        }

        public static TypeSort SortByMaxElementRow(int[] array1, int[] array2)
        {
            if ((array1 == null) || (array2 == null))
                throw new ArgumentNullException();

            if (array1.Max() > array2.Max())
                return TypeSort.Ascending;
            else
                return TypeSort.Descending;
        }

        public static TypeSort SortByMinElementRow(int[] array1, int[] array2)
        {
            if ((array1 == null) || (array2 == null))
                throw new ArgumentNullException();

            if (array1.Min() > array2.Min())
                return TypeSort.Ascending;
            else
                return TypeSort.Descending;
        }
    }
}
