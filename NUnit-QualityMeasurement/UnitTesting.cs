using NUnit.Framework;
using QualityMeasurement;

namespace NUnit_QualityMeasurement
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Give_0_Feet_and_0_Feet_Should_Return_Equal()
        {
            Feet feet = new Feet(0);
            bool result = feet.ConvertFeetValue(new Feet(0));
            Assert.IsTrue(result);
        }
    }
}