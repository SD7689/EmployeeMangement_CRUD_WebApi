// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Msmq.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurement_Backend
{
    using Experimental.System.Messaging;
    using System;
    using System.IO;

    /// <summary>
    ///Msmq Class
    /// </summary>
    public class Msmq
    {

        /// <summary>
        /// SendMessageToQueue method with 2 parameters
        /// </summary>
        /// <param name="ConversionValue"></param>
        /// <param name="value"></param>
        public void SendMessageToQueue(string ConversionValue ,decimal value)
        {
            // check if queue exists, if not create it
            MessageQueue msMq = null;
            string queueName = @".\private$\Send";

            if (!MessageQueue.Exists(queueName))
            {
                msMq = MessageQueue.Create(queueName);
            }
            else
            {
                msMq = new MessageQueue(queueName);
            }
            try
            {
                var result = ConversionValue  +  value;
                msMq.Send(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ReceiveMessageFromQueue method
        /// </summary>
        //public void ReceiveMessageFromQueue()
        //{
           
        //    finally
        //    {
        //        MyQueue.Close();
        //    }
        //}
    }
}
