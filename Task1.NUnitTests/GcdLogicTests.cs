using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;

namespace Task1.NUnitTests
{
    [TestFixture]
    public class GcdLogicTests
    {
        [TestCase(1, 2 , Result = 1)]
        [TestCase(2, -2, Result = 2)]
        [TestCase(9, 3, Result = 3)]
        [TestCase(150, 100, Result = 50)]
        public int GetNodAlgEvklid_ReturnedValue(int number1, int number2)
        {
            return Task1.GcdLogic.GetGcdEuclid(number1, number2);
        }


        [TestCase(1, 2, Result = 1)]
        [TestCase(2, -2, Result = 2)]
        [TestCase(9, 3, Result = 3)]
        [TestCase(150, 100, Result = 50)]
        public int GetNodAlgEvklidBinary_ReturnedValue(int number1, int number2)
        {
            return Task1.GcdLogic.GetGcdEuclidBinary(number1, number2);
        }


        [TestCase(typeof(ArgumentException), new int[] {})]
        public void GetNod_returnedException(Type exception, params int[] numbers)
        {
            Assert.Throws(exception, () => Task1.GcdLogic.GetGcdEuclid(numbers));
        }

        [TestCase(1, 2, 3, Result = 1)]
        [TestCase(2, -2, 4, 8, Result = 2)]
        [TestCase(new int[] {7, 14, 28}, Result = 7)]
        [TestCase(new int[] {1}, Result = 1)]
        public int GetNod_ReturnedValue(params int[] numbers)
        {
            return Task1.GcdLogic.GetGcdEuclid(numbers);
        }
    }
}
