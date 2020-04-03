// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tests.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace NUnit_QualityMeasurement
{
    using NUnit.Framework;
    using QualityMeasurement;

    /// <summary>
    /// Tests Class.
    /// </summary>
    public class Tests
    {

        /// <summary>
        /// Give_0_Feet_and_0_Feet_Should_Return_Equal.
        /// </summary>
        [Test]
        public void Give_0_Feet_and_0_Feet_Should_Return_Equal()
        {
            UnitCheck feet = new UnitCheck("Feet", 0);
            int result = feet.EqualsValue();
            Assert.AreEqual(0, result);

        }

        /// <summary>
        /// PerForm_Test_For_Equality_Null_Check.
        /// </summary>
        [Test]
        public void PerForm_Test_For_Equality_Null_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Equality_Ref_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Type_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Equality_Type_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Value_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Equality_Value_Check()
        {
            UnitCheck feet = new UnitCheck("Feet", 3);
            int result = feet.EqualsValue();
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// Give_0_Inch_and_0_Inch_Should_Return_Equal.
        /// </summary>
        [Test]
        public void Give_0_Inch_and_0_Inch_Should_Return_Equal()
        {
            UnitCheck inch = new UnitCheck("Inch",0);
            int result = inch.EqualsValue();
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// PerForm_Test_TC1_8_For_Equality_Null_Check.
        /// </summary>
        [Test]
        public void PerForm_Test_TC1_8_For_Equality_Null_Check()
        {
            UnitCheck inch = new UnitCheck("Inch",0);
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_TC1_9_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void Perform_Test_TC1_9_For_Equality_Ref_Check()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_TC1_10_For_Equality_Type_Check.
        /// </summary>
        [Test]
        public void Perform_Test_TC1_10_For_Equality_Type_Check()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool result = inch.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_TC1_11_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void Perform_Test_TC1_11_For_Equality_Ref_Check()
        {
            UnitCheck inch = new UnitCheck("Inch",3);
            int result = inch.EqualsValue();
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// Give_0_Feet_and_0_Inch_Should_Return_Equal.
        /// </summary>
        [Test]
        public void Give_0_Feet_and_0_Inch_Should_Return_Equal()
        {
            UnitCheck feet = new UnitCheck("Feet",0);
            int expected = feet.EqualsValue();
            UnitCheck inch = new UnitCheck("Inch",0);
            int actual = inch.EqualsValue();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Compare_1ft_Not_Equal_to_1inch_return_False.
        /// </summary>
        [Test]
        public void Compare_1ft_Not_Equal_to_1inch_return_False()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            int actual = feet.ConvertFeetToInch();
            Assert.AreNotEqual(1, actual);
        }

        /// <summary>
        /// Compare_1inch_Not_Equal_to_1ft_return_False.
        /// </summary>
        [Test]
        public void Compare_1inch_Not_Equal_to_1ft_return_False()
        {
            UnitCheck inch = new UnitCheck("Inch", 1);
            double actual = inch.ConvertInchToFeet();
            Assert.AreNotEqual(1, actual);
        }

        /// <summary>
        /// Compare_1Feet_Equal_to_12_inch_return_True.
        /// </summary>
        [Test]
        public void Compare_1Feet_Equal_to_12_inch_return_True()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            int actual = feet.ConvertFeetToInch();
            Assert.AreEqual(12,actual);
        }

        /// <summary>
        /// Compare_12_inch_Equal_to_1_Feet_return_True.
        /// </summary>
        [Test]
        public void Compare_12_inch_Equal_to_1_Feet_return_True()
        {
            UnitCheck inch = new UnitCheck("Inch", 12);
            double actual = inch.ConvertInchToFeet();
            Assert.AreEqual(1, actual);
        }

        /// <summary>
        /// Compare_3_Feet_Equal_to_1_Yard_return_True.
        /// </summary>
        [Test]
        public void Compare_3_Feet_Equal_to_1_Yard_return_True()
        {
            UnitCheck feet = new UnitCheck("Feet", 3);
            double actual = feet.ConverFeetintoYard();
            Assert.AreEqual(1, actual);
        }

        /// <summary>
        /// Compare_1_Feet_Not_Equal_to_1_Yard_return_True.
        /// </summary>
        [Test]
        public void Compare_1_Feet_Not_Equal_to_1_Yard_return_True()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            double actual = feet.ConverFeetintoYard();
            Assert.AreNotEqual(1, actual);
        }

        /// <summary>
        /// Compare_1_inch_Not_Equal_to_1_Yard_return_True.
        /// </summary>
        [Test]
        public void Compare_1_inch_Not_Equal_to_1_Yard_return_True()
        {
            UnitCheck inch = new UnitCheck("Inch", 1);
            double actual = inch.InchToYard();
            Assert.AreNotEqual(1, actual);
        }

        /// <summary>
        /// Compare_1_Yard_Equal_to_36_inch_return_True.
        /// </summary>
        [Test]
        public void Compare_1_Yard_Equal_to_36_inch_return_True()
        {
            UnitCheck yard = new UnitCheck("Yard", 1);
            int actual = yard.YardToInch();
            Assert.AreEqual(36, actual);
        }

        /// <summary>
        /// Compare_36_inch_Equal_to_1_Yard_return_True.
        /// </summary>
        [Test]
        public void Compare_36_inch_Equal_to_1_Yard_return_True()
        {
            UnitCheck inch = new UnitCheck("Inch", 36);
            double actual = inch.InchToYard();
            Assert.AreEqual(1, actual);
        }

        /// <summary>
        /// Compare_1_Yard_Equal_to_3_Feet_return_True.
        /// </summary>
        [Test]
        public void Compare_1_Yard_Equal_to_3_Feet_return_True()
        {
            UnitCheck yard = new UnitCheck("Yard", 1);
            int actual = yard.YardToFeet();
            Assert.AreEqual(3, actual);
        }

        /// <summary>
        /// PerForm_Test_For_Equality_Null_Check.
        /// </summary>
        [Test]
        public void PerForm_Test_For_Gram_Equality_Null_Check()
        {
            UnitCheck gram = new UnitCheck("Gram");
            bool result = gram.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Gram_Equality_Ref_Check()
        {
            UnitCheck gram = new UnitCheck("Gram");
            bool result = gram.Equals(gram);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Type_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Gram_Equality_Type_Check()
        {
            UnitCheck gram = new UnitCheck("Gram");
            bool result = gram.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Value_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Gram_Equality_Value_Check()
        {
            UnitCheck gram = new UnitCheck("Gram", 3);
            int result = gram.EqualsValue();
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// PerForm_Test_For_Equality_Null_Check.
        /// </summary>
        [Test]
        public void PerForm_Test_For_KiloGram_Equality_Null_Check()
        {
            UnitCheck kilogram = new UnitCheck("KiloGram");
            bool result = kilogram.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_KiloGram_Equality_Ref_Check()
        {
            UnitCheck kilogram = new UnitCheck("KiloGram");
            bool result = kilogram.Equals(kilogram);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Type_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_KiloGram_Equality_Type_Check()
        {
            UnitCheck kilogram = new UnitCheck("KiloGram");
            bool result = kilogram.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Value_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_KiloGram_Equality_Value_Check()
        {
            UnitCheck kilogram = new UnitCheck("KiloGram", 3);
            int result = kilogram.EqualsValue();
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// PerForm_Test_For_Equality_Null_Check.
        /// </summary>
        [Test]
        public void PerForm_Test_For_Celcius_Equality_Null_Check()
        {
            UnitCheck celcius = new UnitCheck("Celcius");
            bool result = celcius.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Celcius_Equality_Ref_Check()
        {
            UnitCheck celcius = new UnitCheck("Celcius");
            bool result = celcius.Equals(celcius);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Type_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Celcius_Equality_Type_Check()
        {
            UnitCheck celcius = new UnitCheck("Celcius");
            bool result = celcius.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Value_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Celcius_Equality_Value_Check()
        {
            UnitCheck celcius = new UnitCheck("Celcius", 3);
            int result = celcius.EqualsValue();
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// PerForm_Test_For_Equality_Null_Check.
        /// </summary>
        [Test]
        public void PerForm_Test_For_Farenheit_Equality_Null_Check()
        {
            UnitCheck farenheit = new UnitCheck("Farenheit");
            bool result = farenheit.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Farenheit_Equality_Ref_Check()
        {
            UnitCheck farenheit = new UnitCheck("Farenheit");
            bool result = farenheit.Equals(farenheit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Type_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Farenheit_Equality_Type_Check()
        {
            UnitCheck farenheit = new UnitCheck("Farenheit");
            bool result = farenheit.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Perform_Test_For_Equality_Value_Check.
        /// </summary>
        [Test]
        public void Perform_Test_For_Farenheit_Equality_Value_Check()
        {
            UnitCheck farenheit = new UnitCheck("Farenheit", 3);
            int result = farenheit.EqualsValue();
            Assert.AreEqual(3, result);
        }
    }
}