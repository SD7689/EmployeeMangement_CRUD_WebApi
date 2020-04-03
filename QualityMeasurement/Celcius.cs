// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Celcius.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QualityMeasurement
{
    using System;

    /// <summary>
    /// Celcius Class.
    /// </summary>
    public class Celcius
    {
        /// <summary>
        /// int celcius property.
        /// </summary>
        public int celcius;

        /// <summary>
        /// celcius Constructor.
        /// </summary>
        public Celcius()
        {
        }

        /// <summary>
        /// celcius Constructor with parameter.
        /// </summary>
        /// <param name="celcius"></param>
        public Celcius(int celcius)
        {
            this.celcius = celcius;
        }

        /// <summary>
        /// EqualsValue Method.
        /// </summary>
        /// <returns> int </returns>
        public int EqualsValue()
        {
            return this.celcius;
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
