// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QmeasurementManager.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager
{
    using Model;
    using Repository;

    /// <summary>
    /// QmeasurementManager impllements IQmeasurementManager.
    /// </summary>
    public class QmeasurementManager : IQmeasurementManager
    {
        /// <summary>
        /// IQmeasurementRepository property.
        /// </summary>
        private IQmeasurementRepository repo;

        /// <summary>
        /// QmeasurementManager constructor.
        /// </summary>
        /// <param name="repo"></param>
        public QmeasurementManager(IQmeasurementRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// CentimetertoMeter method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal CentimetertoMeter(Qmeasurement value)
        {
            return this.repo.CentimetertoMeter(value);
        }

        /// <summary>
        /// FeettoInch method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal FeettoInch(Qmeasurement value)
        {
            return this.repo.FeettoInch(value);
        }

        /// <summary>
        /// GmtoKg method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal GmtoKg(Qmeasurement value)
        {
            return this.repo.GmtoKg(value);
        }

        /// <summary>
        /// InchToFeet method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal InchToFeet(Qmeasurement value)
        {
            return this.repo.InchToFeet(value);
        }

        /// <summary>
        /// KgtoGm method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal KgtoGm(Qmeasurement value)
        {
            return this.repo.KgtoGm(value);
        }

        /// <summary>
        /// MetertoCentimeter method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal MetertoCentimeter(Qmeasurement value)
        {
            return this.repo.MetertoCentimeter(value);
        }
    }
}
