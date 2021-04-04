using System;
using BeFit.Classes;
using NUnit.Framework;

namespace BeFit.Tests
{
    [TestFixture]
    public class AccuracyAbsTests
    {
        [TestCase(13,  ExpectedResult = 13)]
        [TestCase(43.02, ExpectedResult = 43.02)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(99.9, ExpectedResult = 99.9)]
        public double ReturnDiffrence_MainValueIsLoverThat100_ReturnValue(double value)
        {
            value = AccuracyAbs.ReturnDiffrence(value) ;
            return value;
        }
        [TestCase(101, ExpectedResult = 99)]
        [TestCase(133.12, ExpectedResult = 66.88)]
        [TestCase(212, ExpectedResult = -12)]
        [TestCase(106, ExpectedResult = 94)]
        public double ReturnDiffrence_MainValueIsHigherThan100_ReturnAbs(double value)
        {
            value = AccuracyAbs.ReturnDiffrence(value);
            return value;
        }
        [Test]
        public void ReturnDiffrence_MainValueIsEqual100()
        {

            double value = AccuracyAbs.ReturnDiffrence(100);
            Assert.That(value == 100);
        }
    }
}
