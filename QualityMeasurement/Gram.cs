// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gram.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QualityMeasurement
{
    using System;

    /// <summary>
    /// Gram class.
    /// </summary>
    public class Gram
    {
        /// <summary>
        /// int Gram property.
        /// </summary>
        public int gram;

        /// <summary>
        /// Gram Constructor.
        /// </summary>
        public Gram()
        {
        }

        /// <summary>
        /// Gram Constructor with parameter.
        /// </summary>
        /// <param name="gram"></param>
        public Gram(int gram)
        {
            this.gram = gram;
        }

        /// <summary>
        /// EqualsValue Method.
        /// </summary>
        /// <returns> int </returns>
        public int EqualsValue()
        {
            return this.gram;
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
