using NUnit.Framework;

using System;
using System.Linq;

namespace CSharp.Extenstions.Tests
{
    public class IntegerUnitTests
    {
        int thisNumber;
        [SetUp]
        public void Setup()
        {
            thisNumber = 1000;
        }

        [Test]
        public void IsGreaterThan()
        {
            var output = thisNumber.IsGreaterThan(999);
            Assert.IsTrue(output);
        }

        [Test]
        public void ReverseDigits()
        {
            var output = thisNumber.ReverseDigits();
            Assert.IsTrue(output == 1);
        }

        [Test]
        public void IsEven()
        {
            var output = thisNumber.IsEven();
            Assert.IsTrue(output);
        }

        [Test]
        public void IsOdd()
        {
            var output = thisNumber.IsOdd();
            Assert.IsTrue(!output);
        }

        [Test]
        public void IsPrime()
        {
            var output = thisNumber.IsPrime();
            Assert.IsTrue(!output);
        }

        [Test]
        public void isPowerOfTwo()
        {
            var output = thisNumber.isPowerOfTwo();
            Assert.IsTrue(!output);
        }

        [Test]
        public void IsInRange()
        {
            var output = thisNumber.IsInRange(999, 1005);
            Assert.IsTrue(output);
        }

        [Test]
        public void Map()
        {
            var output = thisNumber.Map(fromLow: 1, fromHigh: 10, toLow: 100, toHigh: 200);
            Assert.IsTrue(output > 0);
        }

        [Test]
        public void ToArray()
        {
            var output = thisNumber.ToArray();
            Assert.IsTrue(output.Length == 4);
        }

        [Test]
        public void Squared()
        {
            var output = thisNumber.Squared();
            Assert.IsTrue(output == 1000000);
        }

        [Test]
        public void To()
        {
            var output = thisNumber.To(1010);
            Assert.IsTrue(output.Count() == 11);
        }

        [Test]
        public void MultiplyBy()
        {
            var output = thisNumber.MultiplyBy(2);
            Assert.IsTrue(output == 2000);
        }


        [Test]
        public void Reset()
        {
            var output = thisNumber.Reset();
            Assert.IsTrue(output == 0);
        }

        [Test]
        public void SecondsToString()
        {
            var output = thisNumber.SecondsToString();
            Assert.IsTrue(output != null);
        }


        [Test]
        public void LCM()
        {
            var output = new int[] { 10, 3, 4, 5, 7 }.LCM();
            Assert.IsTrue(output != null);
        }

        [Test]
        public void ToDecimal()
        {
            var output = thisNumber.ToDecimal();
            decimal temp;
            bool isDecimal = decimal.TryParse(output.ToString(), out temp);
            Assert.IsTrue(isDecimal);
        }

        [Test]
        public void PadLeft()
        {
            var output = thisNumber.PadLeft(9).Replace(" ", "_");
            Assert.IsTrue(output.Length == (thisNumber.ToString().Length + 5));
        }

        [Test]
        public void PadLeft2()
        {
            var output = thisNumber.PadLeft(9, '_');
            Assert.IsTrue(output.Length == (thisNumber.ToString().Length + 5));
        }

        [Test]
        public void PadRight()
        {
            var output = thisNumber.PadRight(9).Replace(" ", "_");
            Assert.IsTrue(output.Length == (thisNumber.ToString().Length + 5));
        }


        [Test]
        public void PadRight2()
        {
            var output = thisNumber.PadLeft(9, '_');
            Assert.IsTrue(output.Length == (thisNumber.ToString().Length + 5));
        }

        [Test]
        public void ToDouble()
        {
            var output = thisNumber.ToDouble();
            double temp;
            bool isDouble = Double.TryParse(output.ToString(), out temp);
            Assert.IsTrue(isDouble);
        }

        [Test]
        public void Replace()
        {
            var output = thisNumber.Replace(0, 2);
            Assert.IsTrue(output == 1222);
        }
    }
}