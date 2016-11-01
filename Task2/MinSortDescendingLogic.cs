using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MinSortDescendingLogic : ICustomComparer
    {
        public int CompareArrays(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();

            if (array1.Min() - array2.Min() > 0)
                return 1;
            else
                return -1;
        }
    }
}
