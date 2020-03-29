// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeMangementCurd_Api
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Program Class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// CreateWebHostBuilder Method.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
