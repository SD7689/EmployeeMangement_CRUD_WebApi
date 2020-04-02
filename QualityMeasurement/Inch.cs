// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inch.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QualityMeasurement
{
    using System;

    /// <summary>
    /// Inch Class.
    /// </summary>
    public class Inch
    {
        /// <summary>
        /// int inch Reference.
        /// </summary>
        public int inch;

        /// <summary>
        /// Inch Constructor.
        /// </summary>
        public Inch()
        {

        }

        /// <summary>
        /// Inch Constructor with parameter.
        /// </summary>
        /// <param name="inch"></param>
        public Inch(int inch)
        {
            this.inch = inch;
        }

        /// <summary>
        /// EqualsValue method.
        /// </summary>
        /// <returns> int value </returns>
        public int EqualsValue()
        {
            return this.inch;
        }

        /// <summary>
        /// Equals Method with parameter.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> Bool </returns>
        public override bool Equals(object obj)
        {
            if ((obj == null )|| Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;
            
             return false;
        }
    }
}
