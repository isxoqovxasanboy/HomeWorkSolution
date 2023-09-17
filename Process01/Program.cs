using System;

namespace Process01
{
    internal partial class Program
    {
        static void Main()
        {
            Console.Write("Enter Power number A: ");
            int numberA = int.Parse(Console.ReadLine());
            //Console.Write("Enter Power number B: ");
            //int numberB = int.Parse(Console.ReadLine());

            //Console.Write("Enter Power number C: ");
            //int numberC = int.Parse(Console.ReadLine());

            //int powerSecond, powerThrid, powerFourth;
            //int count, sum;


            #region First issues;
            //PowerNumbers(numberA, out powerThrid);
            //Console.WriteLine(powerThrid);    
            #endregion

            #region Second issues;
            //PowerNumbers(numberA, out powerSecond, out powerThrid, out powerFourth);
            //Console.WriteLine(powerSecond + " " + powerThrid + " " + powerFourth);
            #endregion

            #region Third issues;
            //DigitCountSum(numberA, out count, out sum);
            //Console.WriteLine();
            //Console.WriteLine($"Number -> {numberA};\nNumber rooms -> {count};\nNumber sum up {sum}");
            #endregion

            #region Fourth issues;
            //InvertDigits(ref numberA);

            //Console.WriteLine(numberA);

            #endregion

            #region Fighth issues
            //Console.Write("Enter Add numberA:");
            //AddRightDigit(ref numberA, int.Parse(Console.ReadLine()));
            //Console.WriteLine(numberA);


            #endregion

            #region Sixth issues
            //Minmax(ref numberA, ref numberB);
            //Console.WriteLine($"NumberA {numberA}\nNumberB {numberB}");

            #endregion

            #region Seventh issues

            //Console.WriteLine($"Sum digit number: {SumRange(numberA)}");

            #endregion

            #region Eighth issues
            //Console.WriteLine(Even(numberA));

            #endregion

            #region Ningth issues

            //Console.WriteLine(IsPrimeNumber(numberA));
            //for (int index = default; index < numberA; index++)
            //{
            //    Console.WriteLine($"{index} -> {IsPrimeNumber(index)}");

            //}



            #endregion

            #region Tenth issues
            Console.WriteLine($"{numberA} -> room number count {DigitCountNumber(numberA)}");


            #endregion

        }

        static void PowerNumbers(int number, out int powerThrid)
        {
            powerThrid = 1;
            powerThrid = (int)Math.Pow(number, 3);

        }
        static void PowerNumbers(int number, out int powerSecond, out int powerThrid, out int powerFourth)
        {
            powerSecond = 1; powerThrid = 1; powerFourth = 1;
            powerSecond = (int)Math.Pow(number, 2);
            powerThrid = (int)Math.Pow(number, 3);
            powerFourth = (int)Math.Pow(number, 4);
        }

        static void DigitCountSum(int number, out int count, out int sum)
        {
            count = 0; sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                count++;
                number /= 10;
            }


        }

        static void InvertDigits(ref int number)
        {
            int reversNumber = 0;

            while (number != 0)
            {
                reversNumber *= 10;
                reversNumber += number % 10;
                number /= 10;
            }
            number = reversNumber;

        }

        static void AddRightDigit(ref int number, int count)
        {
            //numberA = ((numberA * 10) + count);
            number = int.Parse($"{number}{count}");
        }

        static void Minmax(ref int numberA, ref int numberB)
        {
            if (numberA < numberB)
            {
                numberB = numberB + numberA;
                numberA = numberB - numberA;
                numberB = numberB - numberA;
            }
        }

        static int SumRange(int number)
        {
            int sum = default;
            for (int index = default; index <= number; index++)
            {
                sum += index;
            }
            return sum;
        }

        static bool Even(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        static bool IsPrimeNumber(int number)
        {
            int count = default(int);

            for (int index = 2; index < number; index++)
            {

                if (number % index == 0)
                {
                    count++;
                }
            }

            if (count < 1)
            {
                return true;
            }


            return false;
        }

        static int DigitCountNumber(int number)
        {
            int count;
            int sum;
            DigitCountSum(number, out count, out sum);
            return count;
        }


    }
}
