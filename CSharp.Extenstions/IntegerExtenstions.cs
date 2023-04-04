using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Extenstions
{
    public static class IntegerExtenstions
    { 
       /// <summary>
       /// An Interger extension method that return true/false 
       /// <example>
       /// <code>
       /// Return true/false value
       /// </code>
       /// </example>
       /// </summary>
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        /// <summary>
        ///  An Interger extension method that reverse the interger digits 
        /// <example>
        /// <code>
        /// Return reverse interger digits
        /// </code>
        /// </example>
        /// </summary>
        public static int ReverseDigits(this int i)
        {
            char[] digits = i.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            return int.Parse(newDigits);
        }

        /// <summary>
        /// An Interger extension method that tell if number is Even
        /// <example>
        /// <code>
        /// Return true/false value
        /// </code>
        /// </example>
        /// </summary>
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        /// <summary>
        /// An Interger extension method that tell if number is Odd
        /// <example>
        /// <code>
        /// Return true/false value
        /// </code>
        /// </example>
        /// </summary>
        public static bool IsOdd(this int i)
        {
            return !(i % 2 == 0);
        }

        /// <summary>
        /// An Interger extension method that tell if number is Prime
        /// <example>
        /// <code>
        /// Return true/false value
        /// </code>
        /// </example>
        /// </summary>
        public static bool IsPrime(this int i)
        {
            if (i <= 1) return false;
            if (i == 2) return true;
            if (i % 2 == 0) return false;

            long N = (long)(Math.Sqrt(i) + 0.5);

            for (int c = 3; c <= N; c += 2)
                if (i % c == 0)
                    return false;

            return true;
        }

        /// <summary>
        /// An Interger extension method that return Power Of Two
        /// <example>
        /// <code>
        /// Return interger value
        /// </code>
        /// </example>
        /// </summary>
        public static bool isPowerOfTwo(this int i)
        {
            return (i != 0) && ((i & (i - 1)) == 0);
        }

        /// <summary>
        /// An Interger extension method that check if number is range between start and end numbers.
        /// <example>
        /// <code>
        /// Return true/false value
        /// </code>
        /// </example>
        /// </summary>
        public static bool IsInRange(this int i, int start, int end)
        {
            return i >= start && i <= end;
        }

        /// <summary>
        /// An Interger extension method that map the number based on from low & high to low & high.
        /// <example>
        /// <code>
        /// Return interger value
        /// </code>
        /// </example>
        /// </summary>
        public static int Map(this int i, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            return (i - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }

        /// <summary>
        /// An Interger extension method that create an integer Array
        /// <example>
        /// <code>
        /// Return interger Array
        /// </code>
        /// </example>
        /// </summary>
        public static int[] ToArray(this int number)
        {
            if (number == 0)
            {
                return new int[0];
            }
            else if (number < 0)
            {
                number = -1 * number;
            }

            List<int> list = new List<int>();
            while (number > 0)
            {
                list.Add(number % 10);
                number = number / 10;
            }
            list.Reverse();

            return list.ToArray();
        }

        /// <summary>
        /// An Interger extension method that return Square
        /// <example>
        /// <code>
        /// Return interger Array
        /// </code>
        /// </example>
        /// </summary>
        public static int Squared(this int intToBeSquared)
        {
            return intToBeSquared * intToBeSquared;
        }

        /// <summary>
        /// An Interger extension method that creates IEnumerable<int> based on first and last number.
        /// <example>
        /// <code>
        /// Return IEnumerable<int>
        /// </code>
        /// </example>
        /// </summary>
        public static IEnumerable<int> To(this int first, int last)
        {
            return Enumerable.Range(first, last - first + 1);
        }

        /// <summary>
        /// An Interger extension method that multiply numbers.
        /// <example>
        /// <code>
        /// Return Integer number
        /// </code>
        /// </example>
        /// </summary>
        public static Int32 MultiplyBy(this Int32 thisNumber, Int32 otherNumber)
        {
            long result = (long)thisNumber * (long)otherNumber;
            if (result > (long)Math.Pow(2, 31) - 1)
                throw new InvalidOperationException(
                   "Product result is larger than an Int32 value.");
            return (Int32)result;
        }

        /// <summary>
        /// An Interger extension method that reset the number to 0.
        /// <example>
        /// <code>
        /// Return Zero 
        /// </code>
        /// </example>
        /// </summary>
        public static int Reset(this int thisNumber)
        {
            return 0;
        }
        
        /// <summary>
        /// Converts the seconds to an hour \ min display string.
        /// </summary>
        /// <param name="totalSeconds">The \total seconds.</param>
        /// <returns>A string in the format x hours y mins.</returns>
        public static string SecondsToString(this int totalSeconds)
        {
            var s = TimeSpan.FromSeconds(totalSeconds);

            return string.Format("{0} hours {1} mins", (int)s.TotalHours, s.Minutes);
        }

        /// <summary>
        /// Uses the Euclidean Algorithm to determine the Least Common Multiplier for an array of integers
        /// </summary>
        /// <param name="values">Array of int values</param>
        /// <returns>The Lease Common Multiplier for values provided</returns>
        public static int LCM(this int[] values)
        {
            var retval = values[0];
            for (var i = 1; i < values.Length; i++)
            {
                retval = GCD(retval, values[i]);
            }
            return retval;
        }

        private static int GCD(int val1, int val2)
        {
            while (val1 != 0 && val2 != 0)
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// An Interger extension method that Convert an integer number to Decimal.
        /// <example>
        /// <code>
        /// Return Decimal 
        /// </code>
        /// </example>
        /// </summary>
        public static Decimal ToDecimal(this int thisNumber)
        {
            return Convert.ToDecimal(thisNumber);
        }

        /// <summary>
        /// An Interger extension method that Convert an integer number to Double.
        /// <example>
        /// <code>
        /// Return Double 
        /// </code>
        /// </example>
        /// </summary>
        public static Double ToDouble(this int thisNumber)
        {
            return Convert.ToDouble(thisNumber);
        }

        /// <summary>
        /// An Interger extension method that Convert an integer number to String.
        /// <example>
        /// <code>
        /// Return String 
        /// </code>
        /// </example>
        /// </summary>
        public static String PadLeft(this int thisNumber, int totalWidth)
        {
            if (!(thisNumber > 0))
                throw new ArgumentOutOfRangeException("totalWidth is less than zero");

            return Convert.ToString(thisNumber).PadLeft(totalWidth);
        }

        //
        // Summary:
        //     Returns a new string that right-aligns the characters in this instance by padding
        //     them with spaces on the left, for a specified total length.
        //
        // Parameters:
        //   totalWidth:
        //     The number of characters in the resulting string, equal to the number of original
        //     characters plus any additional padding characters.
        //
        // Returns:
        //     A new string that is equivalent to this instance, but right-aligned and padded
        //     on the left with as many spaces as needed to create a length of totalWidth. However,
        //     if totalWidth is less than the length of this instance, the method returns a
        //     reference to the existing instance. If totalWidth is equal to the length of this
        //     instance, the method returns a new string that is identical to this instance.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     totalWidth is less than zero.
        public static String PadLeft(this int thisNumber, int totalWidth, char paddingChar)
        {
            if (!(thisNumber > 0))
                throw new ArgumentOutOfRangeException("totalWidth is less than zero");

            return Convert.ToString(thisNumber).PadLeft(totalWidth, paddingChar);
        }

        // Summary:
        //     Returns a new string that left-aligns the characters in this string by padding
        //     them with spaces on the right, for a specified total length.
        //
        // Parameters:
        //   totalWidth:
        //     The number of characters in the resulting string, equal to the number of original
        //     characters plus any additional padding characters.
        //
        // Returns:
        //     A new string that is equivalent to this instance, but left-aligned and padded
        //     on the right with as many spaces as needed to create a length of totalWidth.
        //     However, if totalWidth is less than the length of this instance, the method returns
        //     a reference to the existing instance. If totalWidth is equal to the length of
        //     this instance, the method returns a new string that is identical to this instance.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     totalWidth is less than zero.
        public static String PadRight(this int thisNumber, int totalWidth)
        {
            if (!(thisNumber > 0))
                throw new ArgumentOutOfRangeException("totalWidth is less than zero");

            return Convert.ToString(thisNumber).PadRight(totalWidth);
        }

        //
        // Summary:
        //     Returns a new string that left-aligns the characters in this string by padding
        //     them on the right with a specified Unicode character, for a specified total length.
        //
        // Parameters:
        //   totalWidth:
        //     The number of characters in the resulting string, equal to the number of original
        //     characters plus any additional padding characters.
        //
        //   paddingChar:
        //     A Unicode padding character.
        //
        // Returns:
        //     A new string that is equivalent to this instance, but left-aligned and padded
        //     on the right with as many paddingChar characters as needed to create a length
        //     of totalWidth. However, if totalWidth is less than the length of this instance,
        //     the method returns a reference to the existing instance. If totalWidth is equal
        //     to the length of this instance, the method returns a new string that is identical
        //     to this instance.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     totalWidth is less than zero.
        public static String PadRight(this int thisNumber, int totalWidth, char paddingChar)
        {
            if (!(thisNumber > 0))
                throw new ArgumentOutOfRangeException("totalWidth is less than zero");

            return Convert.ToString(thisNumber).PadRight(totalWidth, paddingChar);
        }

        //
        // Summary:
        //     Returns a new string in which all occurrences of a specified Unicode character
        //     in this instance are replaced with another specified Unicode character.
        //
        // Parameters:
        //   oldChar:
        //     The Unicode character to be replaced.
        //
        //   newChar:
        //     The Unicode character to replace all occurrences of oldChar.
        //
        // Returns:
        //     A string that is equivalent to this instance except that all instances of oldChar
        //     are replaced with newChar. If oldChar is not found in the current instance, the
        //     method returns the current instance unchanged.
        public static int Replace(this int thisNumber, int x, int y)
        {
            return int.Parse(Convert.ToString(thisNumber).Replace(x.ToString(), y.ToString()));
        }
    }
}
