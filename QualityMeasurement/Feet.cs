// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feet.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QualityMeasurement
{
    using System;

    /// <summary>
    /// Feet Class.
    /// </summary>
    public class Feet 
    {
        /// <summary>
        /// int feet property.
        /// </summary>
        public int feet;

        /// <summary>
        /// Feet Constructor.
        /// </summary>
        public Feet()
        {
        }

        /// <summary>
        /// Feet Constructor with parameter.
        /// </summary>
        /// <param name="feet"></param>
        public Feet(int feet)
        {
            this.feet = feet;
        }

        /// <summary>
        /// EqualsValue Method.
        /// </summary>
        /// <returns> int </returns>
        public int EqualsValue()
        {
           return this.feet;
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
