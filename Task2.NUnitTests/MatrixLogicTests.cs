using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2.NUnitTests
{
    [TestFixture]
    public class MatrixLogicTests
    {
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1 , 2 }, Result = 1)]
        [TestCase(new int[] { 10, 12, 100 }, new int[] { 92, 2, 1, 1, 1 }, 1)]
        [TestCase(new int[] { 3 }, new int[] { 1, 2, 1 }, Result = -1)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 100 }, Result = -1)]
        public int SortByAscendingSumElementsRows_returnedValue(int[] array1, int[] array2)
        {
            SumSortAscendingLogic sort = new SumSortAscendingLogic();
            return sort.CompareArrays (array1, array2);
        }

        [TestCase(null, null, typeof(ArgumentNullException))]
        [TestCase(null, new int[] {1, 2}, typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2 }, null, typeof(ArgumentNullException))]
        public void SortByAscendingSumElementsRows_returnedArgumentException(int[] array1, int[] array2, Type exception)
        {
            SumSortAscendingLogic sort = new SumSortAscendingLogic();
            Assert.Throws(exception, () => sort.CompareArrays(array1, array2)); 
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, Result = 1)]
        [TestCase(new int[] { 10, 12, 100 }, new int[] { 92, 2, 1, 1, 1 }, Result = 1)]
        [TestCase(new int[] { 3 }, new int[] { 1, 2, 1 }, Result = 1)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 100 }, Result = -1)]
        public int SortByAscendingMaxElementRow_returnedValue(int[] array1, int[] array2)
        {
            MaxSortAscendingLogic sort = new MaxSortAscendingLogic();
            return sort.CompareArrays(array1, array2);
        }


        [TestCase(null, null, typeof(ArgumentNullException))]
        [TestCase(null, new int[] { 1, 2 }, typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2 }, null, typeof(ArgumentNullException))]
        public void SortByMaxElementRow_returnedArgumentException(int[] array1, int[] array2, Type exception)
        {
            MaxSortAscendingLogic sort = new MaxSortAscendingLogic();
            Assert.Throws(exception, () => sort.CompareArrays(array1, array2));
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, Result = -1)]
        [TestCase(new int[] { 10, 12, 100 }, new int[] { 92, 2, 1, 1, 1 }, Result = -1)]
        [TestCase(new int[] { 3 }, new int[] { 1, 2, 1 }, Result = -1)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 100 }, Result = 1)]
        public int SortByMinElementRow_returnedValue(int[] array1, int[] array2)
        {
            MinSortAscendingLogic sort = new MinSortAscendingLogic();
            return sort.CompareArrays(array1, array2);
        }

        [TestCase(null, null, typeof(ArgumentNullException))]
        [TestCase(null, new int[] { 1, 2 }, typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2 }, null, typeof(ArgumentNullException))]
        public void SortByMinElementRow_returnedArgumentException(int[] array1, int[] array2, Type exception)
        {
            MinSortAscendingLogic sort = new MinSortAscendingLogic();
            Assert.Throws(exception, () => sort.CompareArrays(array1, array2));
        }
    }
}
