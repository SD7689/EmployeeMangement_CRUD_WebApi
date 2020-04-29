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

        Msmq send = new Msmq();

        /// <summary>
        /// ValuesController Constructor.
        /// </summary>
        /// <param name="manager"></param>
        public ValuesController(IQmeasurementManager manager)
        {
            this.manager = manager;
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
                send.SendMessageToQueue("Inch", result);
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
                send.SendMessageToQueue("Feet", result);
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
                send.SendMessageToQueue("Centimeter", result);
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
                send.SendMessageToQueue("Meter", result);
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
                send.SendMessageToQueue("Gram", result);
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
                send.SendMessageToQueue("KiloGram", result);
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}