using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class NodLogic
    {
        public static int GetNod(Func<int, int, int> algEvkl, params int[] numbers)
        {
            if (numbers == null)
                throw new NullReferenceException();
            if (numbers.Length == 0)
                throw new ArgumentException();
            if (numbers.Length == 1)
                return numbers[0];
            
            int nod = int.MaxValue;
            nod = algEvkl(numbers[0], numbers[1]);
            if (numbers.Length > 2)
            {
                for (int i = 2; i < numbers.Length; i++)
                {
                    nod = algEvkl(numbers[i], nod);
                }
            }
            return nod;
        }

        public static double GetNod(Func<int, int, int> algEvkl, out double workedTime, params int[] numbers)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            double res = GetNod(algEvkl, numbers);
            watch.Stop();
            workedTime = watch.ElapsedTicks;
            return res;
        }

        public static int GetNodAlgEvklidBinary(int number1, int number2)
        {
            if ((number1 == number2) && (number1 == 0))
                throw new ArgumentException();

            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            if (number1 == number2) return number1;
            if (number1 == 0) return number2;
            if (number2 == 0) return number1;

            if ((number1 & 1) == 0)
            {
                if ((number2 & 1) == 1)
                {
                    return GetNodAlgEvklidBinary(number1 >> 1, number2);
                }
                else
                {
                    return GetNodAlgEvklidBinary(number1 >> 1, number2 >> 1) << 1;
                }
            }

            if ((number2 & 1) == 0)
                return GetNodAlgEvklidBinary(number1, number2 >> 1);

            if (number1 > number2)
            {
                return GetNodAlgEvklidBinary((number1 - number2) >> 1, number2);
            }

            return GetNodAlgEvklidBinary((number2 - number1) >> 1, number1);
        }

        public static int GetNodAlgEvklid(int number1, int number2)
        {
            if ((number1 == number2) && (number1 == 0))
                throw new ArgumentException();

            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            if ((number1 == number2) && (number1 != 0))
                return number1;
            

            if (number1 != 0 || number2 != 0)
            {
                int nod = 0;
                int rest = 0;
                do
                {
                    int resDivision = Math.Max(number1, number2) / Math.Min(number1, number2);
                    rest = Math.Max(number1, number2) % Math.Min(number1, number2);

                    number1 = Math.Min(number1, number2);
                    nod = Math.Min(number1, number2);
                    number2 = rest;

                } while (rest != 0);

                return nod;
            }
            else
            {
                if (number1 == 0)
                    return number2;
                else
                    return number1;
            }
        }
    }
}
