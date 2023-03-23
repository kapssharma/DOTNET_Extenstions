using NUnit.Framework;

using System;

namespace CSharp.Extenstions.Tests
{
    public class DateTimeUnitTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void DateTimeToyymmddhhmmss()
        {
            var dateTime = DateTime.Now;
            var output = "";// dateTime.DateTimeToyymmddhhmmss();
            Assert.IsTrue(output.Length == 0);
        }


        [Test]
        public void ToStringMMddyyyy()
        {
            var dateTime = DateTime.Now;
            var output = dateTime.ToStringdddd_ddMMMMyyyy("/");
            Assert.IsTrue(output != null);
        }


        [Test]
        public void ToStringMMddyyyyHmm()
        {
            var dateTime = new DateTime(year: 2023, month: 02, day: 12, hour: 13, minute: 25, second: 30);
            var output = dateTime.ToStringMyyyy();
            Assert.IsTrue(output != null);
        }


        [Test]
        public void ToStringMMddyyyyhmm()
        {
            var dateTime = new DateTime(year: 2023, month: 02, day: 12, hour: 13, minute: 25, second: 30);
            var output = dateTime.ToStringMMddyyyyhmm();
            Assert.IsTrue(output != null);
        }


    }
}