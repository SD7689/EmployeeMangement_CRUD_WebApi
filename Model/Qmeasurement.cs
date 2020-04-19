// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Qmeasurement.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Model
{

    /// <summary>
    /// Qmeasurement Class.
    /// </summary>
    public class Qmeasurement
    {
        private decimal feet;

        private decimal inch;

        private decimal meter;

        private decimal centimeter;

        private decimal gram;

        private decimal kilogram;


        /// <summary>
        /// Feet property Get Set.
        /// </summary>
        public decimal Feet
        {
            get
            {
                return this.feet;
            }
            set
            {
                this.feet = value;
            }
        }

        /// <summary>
        /// Inch property Get Set
        /// </summary>
        public decimal Inch
        {
            get
            {
                return this.inch;
            }
            set
            {
                this.inch = value;
            }
        }

        /// <summary>
        /// Gram property Get Set
        /// </summary>
        public decimal Gram
        {
            get
            {
                return this.gram;
            }
            set
            {
                this.gram = value;
            }
        }

        /// <summary>
        /// Meter property Get Set
        /// </summary>
        public decimal Meter
        {
            get
            {
                return this.meter;
            }
            set
            {
                this.meter = value;
            }
        }

        /// <summary>
        /// Centimeter property Get Set
        /// </summary>
        public decimal Centimeter
        {
            get
            {
                return this.centimeter;
            }
            set
            {
                this.centimeter = value;
            }
        }

        /// <summary>
        /// KiloGram property Get Set
        /// </summary>
        public decimal KiloGram
        {
            get
            {
                return this.kilogram;
            }
            set
            {
                this.kilogram = value;
            }

        }
    }
}
