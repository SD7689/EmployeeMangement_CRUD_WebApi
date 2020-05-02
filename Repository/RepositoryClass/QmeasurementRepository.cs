// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QmeasurementRepository.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository
{
    using Model;
    using Repository.RepositoryClass;

    /// <summary>
    /// QmeasurementRepository implements IQmeasurementRepository.
    /// </summary>
    public class QmeasurementRepository : IQmeasurementRepository
    {

        /// <summary>
        /// RedisCache class object created.
        /// </summary>
        RedisCache redisCache = new RedisCache();

        /// <summary>
        /// FeettoInch method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal FeettoInch(Qmeasurement value)
        {
            decimal result = value.Feet * 12;
            redisCache.RedisConnection($"Feet", result.ToString());
            return result;
        }

        /// <summary>
        /// InchToFeet method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal InchToFeet(Qmeasurement value)
        {
            decimal result = value.Inch / 12;
            redisCache.RedisConnection($"Inch", result.ToString());
            return result;
        }

        /// <summary>
        /// MetertoCentimeter method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal MetertoCentimeter(Qmeasurement value)
        {
            decimal result = value.Meter * 100;
            redisCache.RedisConnection($"Meter", result.ToString());
            return result;
        }

        /// <summary>
        /// CentimetertoMeter method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal CentimetertoMeter(Qmeasurement value)
        {
            decimal result = value.Centimeter / 100;
            redisCache.RedisConnection($"Centimeter", result.ToString());
            return result;
        }

        /// <summary>
        /// GmtoKg method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal GmtoKg(Qmeasurement value)
        {
            decimal result = value.Gram / 1000;
            redisCache.RedisConnection($"Gram", result.ToString());
            return result;
        }

        /// <summary>
        /// KgtoGm method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value</returns>
        public decimal KgtoGm(Qmeasurement value)
        {
            decimal result = value.KiloGram * 1000;
            redisCache.RedisConnection($"KiloGram", result.ToString());
            return result;
        }
    }
}
