// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantiyMeasurement_Backend
{
    using Experimental.System.Messaging;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using QuantityMeasurement_Backend;
    using System;
    using System.IO;

    /// <summary>
    /// Program Class.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            MessageQueue MyQueue = null;
            string path = @".\private$\Send";
            try
            {

                MyQueue = new MessageQueue(path);
                Message[] messages = MyQueue.GetAllMessages();
                if (messages.Length > 0)
                {
                    foreach (Message msg in messages)
                    {
                        msg.Formatter = new XmlMessageFormatter(new String[] { "System.String,mscorlib" });
                        string message = msg.Body.ToString();
                        MyQueue.Receive();
                        File.WriteAllText(@"C:\Users\Shiv\source\repos\QuantiyMeasurement_Backend\msmqReciver.txt", message);
                    }
                    MyQueue.Refresh();
                }
                else
                {
                    Console.WriteLine("No New Messages in Message Queue");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            BuildWebHost(args).Run();
        }
        
        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();
    }
}
