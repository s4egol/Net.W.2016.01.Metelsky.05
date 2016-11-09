using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class GcdLogic
    {
        public static int GetGcd(Func<int, int, int> functionFindingGcd, int numberOne, int numberTwo)
            => GetGcdPattern(functionFindingGcd, numberOne, numberTwo);

        public static int GetGcd(Func<int, int, int> functionFindingGcd, int numberOne, int numberTwo, int numberThree)
            => GetGcdPattern(functionFindingGcd, numberOne, numberTwo, numberThree);

        public static int GetGcd(Func<int, int, int> functionFindingGcd, params int[] numbers)
            => GetGcdPattern(functionFindingGcd, numbers);


        public static int GetGcdWithTimeExecution(Func<int, int, int> functionFindingGcd, out double workedTime, params int[] numbers)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int resultGcd = GetGcd(functionFindingGcd, numbers);
            watch.Stop();
            workedTime = watch.ElapsedTicks;
            return resultGcd;
        }


        public static int CalculateGcdEuclidBinary(int number1, int number2)
        {
            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            if (number1 == number2) return number1;
            if (number1 == 0) return number2;
            if (number2 == 0) return number1;

            if ((number1 & 1) == 0)
            {
                if ((number2 & 1) == 1)
                    return CalculateGcdEuclidBinary(number1 >> 1, number2);
                else
                    return CalculateGcdEuclidBinary(number1 >> 1, number2 >> 1) << 1;
            }

            if ((number2 & 1) == 0)
                return CalculateGcdEuclidBinary(number1, number2 >> 1);

            if (number1 > number2)
                return CalculateGcdEuclidBinary((number1 - number2) >> 1, number2);

            return CalculateGcdEuclidBinary((number2 - number1) >> 1, number1);
        }

        public static int CalculateGcdEuclid(int number1, int number2)
        {
            if ((number1 == number2) && (number1 == 0))
                throw new ArgumentException();

            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            if ((number1 == number2) && (number1 != 0))
                return number1;
            

            if (number1 != 0 || number2 != 0)
            {
                int gcd = 0;
                int rest = 0;
                do
                {
                    rest = Math.Max(number1, number2) % Math.Min(number1, number2);
                    number1 = Math.Min(number1, number2);
                    gcd = Math.Min(number1, number2);
                    number2 = rest;
                }
                while (rest != 0);

                return gcd;
            }
            else
            {
                if (number1 == 0)
                    return number2;
                else
                    return number1;
            }
        }

        private static int GetGcdPattern(Func<int, int, int> functionFindingGcd, params int[] numbers)
        {
            if (numbers == null)
                throw new NullReferenceException();
            if (numbers.Length == 0)
                throw new ArgumentException();
            if (numbers.Length == 1)
                return numbers[0];

            int gcd = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                gcd = functionFindingGcd(gcd, numbers[i]);
            }

            return gcd;
        }
    }
}
