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

        [Test]
        public void PerForm_Test_For_Equality_Null_Check()
        {
            Feet feet = new Feet(null);
            bool result = feet.Equals(new Feet(0));
            Assert.IsTrue(result);
        }
    }
}