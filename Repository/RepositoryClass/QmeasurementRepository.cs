// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QmeasurementRepository.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository
{
    using Model;

    /// <summary>
    /// QmeasurementRepository implements IQmeasurementRepository.
    /// </summary>
    public class QmeasurementRepository : IQmeasurementRepository
    {

        /// <summary>
        /// FeettoInch method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal FeettoInch(Qmeasurement value)
        {
            return value.Feet * 12; 
        }

        /// <summary>
        /// InchToFeet method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal InchToFeet(Qmeasurement value)
        {
            return value.Inch / 12;
        }

        /// <summary>
        /// GmtoKg method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal GmtoKg(Qmeasurement value)
        {
            return value.Gram / 1000;
        }

        /// <summary>
        /// MetertoCentimeter method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal MetertoCentimeter(Qmeasurement value)
        {
            return value.Meter * 100;
        }

        /// <summary>
        /// CentimetertoMeter method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal CentimetertoMeter(Qmeasurement value)
        {
            return value.Centimeter / 100;
        }

        /// <summary>
        /// KgtoGm method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal KgtoGm(Qmeasurement value)
        {
            return value.KiloGram * 1000;
        }
    }
}
