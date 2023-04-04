using NUnit.Framework;

using System;

namespace CSharp.Extenstions.Tests
{
    public class DateTimeUnitTests
    {
        DateTime dateTime;
        [SetUp]
        public void Setup()
        {
            dateTime = new DateTime(year: 2023, month: 02, day: 12, hour: 13, minute: 25, second: 30);
        }

        [Test]
        public void ToStringdddd_ddMMMMyyyy()
        {
            var output = dateTime.ToStringdddd_ddMMMMyyyy();
            Assert.IsTrue(output != null);
        }


        [Test]
        public void ToStringMMddyyyy()
        {
            var output = dateTime.ToStringdddd_ddMMMMyyyy("/");
            Assert.IsTrue(output != null);
        }


        [Test]
        public void ToStringMMddyyyyHmm()
        {
            var output = dateTime.ToStringMyyyy();
            Assert.IsTrue(output != null);
        }


        [Test]
        public void ToStringMMddyyyyhmm()
        {
            var output = dateTime.ToStringMMddyyyyhmm();
            Assert.IsTrue(output != null);
        }


    }
}