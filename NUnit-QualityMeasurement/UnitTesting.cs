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
            UnitCheck feet = new UnitCheck("Feet", 0);
            int result = feet.EqualsValue();
            Assert.AreEqual(0, result);

        }

        [Test]
        public void PerForm_Test_For_Equality_Null_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_For_Equality_Ref_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_For_Equality_Type_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_For_Equality_Value_Check()
        {
            UnitCheck feet = new UnitCheck("Feet", 3);
            int result = feet.EqualsValue();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Give_0_Inch_and_0_Inch_Should_Return_Equal()
        {
            UnitCheck inch = new UnitCheck("Inch",0);
            int result = inch.EqualsValue();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void PerForm_Test_TC1_8_For_Equality_Null_Check()
        {
            UnitCheck inch = new UnitCheck("Inch",0);
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_TC1_9_For_Equality_Ref_Check()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_TC1_10_For_Equality_Type_Check()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool result = inch.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_TC1_11_For_Equality_Ref_Check()
        {
            UnitCheck inch = new UnitCheck("Inch",3);
            int result = inch.EqualsValue();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Give_0_Feet_and_0_Inch_Should_Return_Equal()
        {
            UnitCheck feet = new UnitCheck("Feet",0);
            int expected = feet.EqualsValue();
            UnitCheck inch = new UnitCheck("Inch",0);
            int actual = inch.EqualsValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Compare_1ft_Not_Equal_to_1inch_return_False()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            int actual = feet.ConvertFeetToInch();
            Assert.AreNotEqual(1, actual);
        }

        [Test]
        public void Compare_1inch_Not_Equal_to_1ft_return_False()
        {
            UnitCheck inch = new UnitCheck("Inch", 1);
            double actual = inch.ConvertInchToFeet();
            Assert.AreNotEqual(1, actual);
        }

        [Test]
        public void Compare_1Feet_Equal_to_12_inch_return_True()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            int actual = feet.ConvertFeetToInch();
            Assert.AreEqual(12,actual);
        }

        [Test]
        public void Compare_12_inch_Equal_to_1_Feet_return_True()
        {
            UnitCheck inch = new UnitCheck("Inch", 12);
            double actual = inch.ConvertInchToFeet();
            Assert.AreEqual(1, actual);
        }
        
        [Test]
        public void Compare_3_Feet_Equal_to_1_Yard_return_True()
        {
            UnitCheck feet = new UnitCheck("Feet", 3);
            double actual = feet.ConverFeetintoYard();
            Assert.AreEqual(1, actual);
        }
        
        [Test]
        public void Compare_1_Feet_Not_Equal_to_1_Yard_return_True()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            double actual = feet.ConverFeetintoYard();
            Assert.AreNotEqual(1, actual);
        }
        
        [Test]
        public void Compare_1_inch_Not_Equal_to_1_Yard_return_True()
        {
            UnitCheck inch = new UnitCheck("Inch", 1);
            double actual = inch.InchToYard();
            Assert.AreNotEqual(1, actual);
        }
    }
}