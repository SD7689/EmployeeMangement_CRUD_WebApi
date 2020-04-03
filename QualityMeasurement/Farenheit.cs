// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Farenheit.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QualityMeasurement
{
    using System;

    /// <summary>
    /// Farenheit Class.
    /// </summary>
    public class Farenheit
    {
        /// <summary>
        /// int Farenheit property.
        /// </summary>
        public double fh;

        /// <summary>
        /// Farenheit Constructor.
        /// </summary>
        public Farenheit()
        {
        }

        /// <summary>
        /// Farenheit Constructor with parameter.
        /// </summary>
        /// <param name="fh"></param>
        public Farenheit(double fh)
        {
            this.fh = fh;
        }

        /// <summary>
        /// EqualsValue Method.
        /// </summary>
        /// <returns> int </returns>
        public double EqualsValue()
        {
            return this.fh;
        }

        /// <summary>
        /// Equals Method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> bool </returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
