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
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1 , 2 }, Result = TypeSort.Ascending)]
        [TestCase(new int[] { 10, 12, 100 }, new int[] { 92, 2, 1, 1, 1 }, Result = TypeSort.Ascending)]
        [TestCase(new int[] { 3 }, new int[] { 1, 2, 1 }, Result = TypeSort.Descending)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 100 }, Result = TypeSort.Descending)]
        public TypeSort SortBySumElementsRows_returnedValue(int[] array1, int[] array2)
        {
            return Task2.MatrixLogic.SortBySumElementsRows(array1, array2);
        }

        [TestCase(null, null, typeof(ArgumentNullException))]
        [TestCase(null, new int[] {1, 2}, typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2 }, null, typeof(ArgumentNullException))]
        public void SortBySumElementsRows_returnedArgumentException(int[] array1, int[] array2, Type exception)
        { 
             Assert.Throws(exception, () => Task2.MatrixLogic.SortBySumElementsRows(array1, array2)); 
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, Result = TypeSort.Ascending)]
        [TestCase(new int[] { 10, 12, 100 }, new int[] { 92, 2, 1, 1, 1 }, Result = TypeSort.Ascending)]
        [TestCase(new int[] { 3 }, new int[] { 1, 2, 1 }, Result = TypeSort.Ascending)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 100 }, Result = TypeSort.Descending)]
        public TypeSort SortByMaxElementRow_returnedValue(int[] array1, int[] array2)
        {
            return Task2.MatrixLogic.SortByMaxElementRow(array1, array2);
        }


        [TestCase(null, null, typeof(ArgumentNullException))]
        [TestCase(null, new int[] { 1, 2 }, typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2 }, null, typeof(ArgumentNullException))]
        public void SortByMaxElementRow_returnedArgumentException(int[] array1, int[] array2, Type exception)
        {
            Assert.Throws(exception, () => Task2.MatrixLogic.SortByMaxElementRow(array1, array2));
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, Result = TypeSort.Ascending)]
        [TestCase(new int[] { 10, 12, 100 }, new int[] { 92, 2, 1, 1, 1 }, Result = TypeSort.Ascending)]
        [TestCase(new int[] { 3 }, new int[] { 1, 2, 1 }, Result = TypeSort.Ascending)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 100 }, Result = TypeSort.Descending)]
        public TypeSort SortByMinElementRow_returnedValue(int[] array1, int[] array2)
        {
            return Task2.MatrixLogic.SortByMaxElementRow(array1, array2);
        }

        [TestCase(null, null, typeof(ArgumentNullException))]
        [TestCase(null, new int[] { 1, 2 }, typeof(ArgumentNullException))]
        [TestCase(new int[] { 1, 2 }, null, typeof(ArgumentNullException))]
        public void SortByMinElementRow_returnedArgumentException(int[] array1, int[] array2, Type exception)
        {
            Assert.Throws(exception, () => Task2.MatrixLogic.SortByMinElementRow(array1, array2));
        }
    }
}
