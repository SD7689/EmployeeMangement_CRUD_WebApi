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
            int result = feet.EqualsValue();
            Assert.AreEqual(0, result);

        }

        [Test]
        public void PerForm_Test_For_Equality_Null_Check()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(null);
            Assert.IsTrue(result); 
        }

        [Test]
        public void Perform_Test_For_Equality_Ref_Check()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_For_Equality_Type_Check()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_For_Equality_Value_Check()
        {
            Feet feet = new Feet(3);
            int result = feet.EqualsValue();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Give_0_Inch_and_0_Inch_Should_Return_Equal()
        {
            Inch inch = new Inch(0);
            int result = inch.EqualsValue();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void PerForm_Test_TC1_8_For_Equality_Null_Check()
        {
            Inch inch = new Inch(0);
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_TC1_9_For_Equality_Ref_Check()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_TC1_10_For_Equality_Type_Check()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(new Inch());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_TC1_11_For_Equality_Ref_Check()
        {
            Inch inch = new Inch(3);
            int result = inch.EqualsValue();
            Assert.AreEqual(3, result);
        }
    }
}