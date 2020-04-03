// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitCheck.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QualityMeasurement
{
    using System;

    /// <summary>
    /// UnitCheck Class.
    /// </summary>
    public class UnitCheck
    {
        /// <summary>
        /// type property string.
        /// </summary>
        public string type;

        /// <summary>
        /// Length Property int.
        /// </summary>
        public int Length;

        /// <summary>
        /// UnitCheck Constructor.
        /// </summary>
        public UnitCheck()
        {

        }

        /// <summary>
        /// UnitCheck Constructor with 2 parameter.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="Length"></param>
        public UnitCheck(string type , int Length)
        {
            this.type = type;
            this.Length = Length;
        }

        /// <summary>
        /// UnitCheck Constructor with parameter.
        /// </summary>
        /// <param name="type"></param>
        public UnitCheck(string type)
        {
            this.type = type;
        }

        /// <summary>
        /// EqualsValue Method.
        /// </summary>
        /// <returns> int value </returns>
        public int EqualsValue()
        {
            return this.Length;
        }

        /// <summary>
        /// ConvertFeetToInch Method.
        /// </summary>
        /// <returns> int value </returns>
        public int ConvertFeetToInch()
        {
            return this.Length * 12;
        }

        /// <summary>
        /// ConvertInchToFeet Method.
        /// </summary>
        /// <returns> int double </returns>
        public double ConvertInchToFeet()
        {
            return this.Length / 12;
        }

        /// <summary>
        /// CelciustoFarenheit Method.
        /// </summary>
        /// <returns></returns>
        public double CelciustoFarenheit()
        {
            return this.Length * 33.8;
        }


        /// <summary>
        /// KgtoGram Method.
        /// </summary>
        /// <returns> int value </returns>
        public int KgtoGram()
        {
            return this.Length * 1000;
        }

        /// <summary>
        /// EqualsMethod with object parameter.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> bool value </returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
