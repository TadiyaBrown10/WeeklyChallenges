using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            public bool CharacterIsALetter(char c)
            {
                return char.IsLetter(c);
            }

            public bool CountOfElementsIsEven(string[] vals)
            {
                if (vals.Length % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool IsNumberEven(int number)
            {
                if (number % 2 == 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }

            public bool IsNumberOdd(int num)
            {
                if (num % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public double SumOfMinAndMax(IEnumerable<double> numbers)
            {
                if (numbers == null)
                {
                    return 0;
                }

                return numbers.Min() + numbers.Max();

            }

            public int GetLengthOfShortestString(string str1, string str2)
            {
                if (str1.Length < str2.Length)
                {
                    return str1.Length;
                }
                else
                {
                    return str2.Length;
                }
            }

            public int Sum(int[] numbers)
            {
                if (numbers == null)
                {
                    return 0;
                }
                return numbers.Sum();
            }

            public int SumEvens(int[] numbers)
            {
                if (numbers == null)
                {
                    return 0;
                }

                var everSum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        everSum += numbers[i];
                    }

                }

                return everSum;
            }

            public bool IsSumOdd(List<int> numbers)
            {
                if (numbers == null)
                {
                    return false;
                }

                return numbers.Sum() % 2 != 0;
            }

            public long CountOfPositiveOddsBelowNumber(long number)
            {
                if (number <= 0)
                {
                    return 0;
                }

                else
                {
                    return number / 2;
                }
            }
    }
}
