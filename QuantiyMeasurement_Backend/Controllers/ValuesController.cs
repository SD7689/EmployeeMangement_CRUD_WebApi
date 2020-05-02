// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValuesController.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurement_Backend.Controllers
{
    using Manager;
    using Microsoft.AspNetCore.Mvc;
    using Model;
    using Repository.RepositoryClass;

    /// <summary>
    /// ValuesController implements ControllerBase.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        /// <summary>
        /// IQmeasurementManager property.
        /// </summary>
        public IQmeasurementManager manager;

        /// <summary>
        /// Msmq Class Object.
        /// </summary>
        Msmq send = new Msmq();

        /// <summary>
        /// RedisCache Class Object.
        /// </summary>
        RedisCache redis = new RedisCache();
        
        /// <summary>
        /// ValuesController Constructor.
        /// </summary>
        /// <param name="manager"></param>
        public ValuesController(IQmeasurementManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// get method with parameter
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [Route("redis")]
        [HttpGet]
        public string get(string key)
        {
            return redis.RedisConnection(key);
        }

        /// <summary>
        /// FeettoInch method.
        /// get api/values Route("FeettoInch")
        /// HttpPost
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value </returns>
        [Route("FeettoInch")]
        [HttpPost]
        public IActionResult FeettoInch(Qmeasurement value)
        {
                var result = this.manager.FeettoInch(value);
                if (result >= 0)
                {
                    return this.Ok(result);
                }

                return this.BadRequest();
        }

        /// <summary>
        /// InchToFeet method.
        /// get api/values Route("InchToFeet")
        /// HttpPost
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value </returns>
        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(Qmeasurement value)
        {
            var result = this.manager.InchToFeet(value);

            if (result >= 0)
            {
                send.SendMessageToQueue(result, "Inch :");
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        /// <summary>
        /// MetertoCentimeter method.
        /// get api/values Route("MetertoCentimeter")
        /// HttpPost
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value </returns>
        [Route("MetertoCentimeter")]
        [HttpPost]
        public IActionResult MetertoCentimeter(Qmeasurement value)
        {
            var result = this.manager.MetertoCentimeter(value);

            if (result >= 0)
            {
                send.SendMessageToQueue(result, "CentiMeter :");
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        /// <summary>
        /// CentimetertoMeter method.
        /// get api/values Route("CentimetertoMeter")
        /// HttpPost
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value </returns>
        [Route("CentimetertoMeter")]
        [HttpPost]
        public IActionResult CentimetertoMeter(Qmeasurement value)
        {
            var result = this.manager.CentimetertoMeter(value);

            if (result >= 0)
            {
                send.SendMessageToQueue(result, "Meter :");
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        /// <summary>
        /// KgtoGm method.
        /// get api/values Route("KgtoGm")
        /// HttpPost
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value </returns>
        [Route("KgtoGm")]
        [HttpPost]
        public IActionResult KgtoGm(Qmeasurement value)
        {
            var result = this.manager.KgtoGm(value);

            if (result >= 0)
            {
                send.SendMessageToQueue(result, "Gram :");
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        /// <summary>
        /// GmtoKg method.
        /// get api/values Route("GmtoKg")
        /// HttpPost
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value </returns>
        [Route("GmtoKg")]
        [HttpPost]
        public IActionResult GmtoKg(Qmeasurement value)
        {
            var result = this.manager.GmtoKg(value);

            if (result >= 0)
            {
                send.SendMessageToQueue(result, "Kilogram :");
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}