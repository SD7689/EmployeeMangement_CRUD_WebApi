// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Kilogram.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QualityMeasurement
{
    using System;

    /// <summary>
    /// Kilogram Class.
    /// </summary>
    public class Kilogram
    {
        /// <summary>
        /// int Kilogram property.
        /// </summary>
        public int kg;

        /// <summary>
        /// Kilogram Constructor.
        /// </summary>
        public Kilogram()
        {
        }

        /// <summary>
        /// Kilogram Constructor with parameter.
        /// </summary>
        /// <param name="kg"></param>
        public Kilogram(int kg)
        {
            this.kg = kg;
        }

        /// <summary>
        /// EqualsValue Method.
        /// </summary>
        /// <returns> int </returns>
        public int EqualsValue()
        {
            return this.kg;
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
