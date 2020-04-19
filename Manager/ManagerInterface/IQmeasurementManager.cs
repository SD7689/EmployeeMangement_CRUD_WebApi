// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQmeasurementManager.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager
{
    using Model;

    /// <summary>
    /// IQmeasurementManager interface.
    /// </summary>
    public interface IQmeasurementManager
    {
        /// <summary>
        /// FeettoInch method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        decimal FeettoInch(Qmeasurement value);

        /// <summary>
        /// InchToFeet method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        decimal InchToFeet(Qmeasurement value);

        /// <summary>
        /// MetertoCentimeter method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        decimal MetertoCentimeter(Qmeasurement value);

        /// <summary>
        /// CentimetertoMeter method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        decimal CentimetertoMeter(Qmeasurement value);

        /// <summary>
        /// KgtoGm method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        decimal KgtoGm(Qmeasurement value);

        /// <summary>
        /// GmtoKg method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        decimal GmtoKg(Qmeasurement value);
    }
}
