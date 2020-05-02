// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RedisCache.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository.RepositoryClass
{
    using StackExchange.Redis;

    /// <summary>
    /// RedisCache Class.
    /// </summary>
    public class RedisCache
    {

        /// <summary>
        /// RedisConnection with parameter.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string RedisConnection(string key)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            //  data.StringSet(key, value);
            string keyValue = data.StringGet(key);
            return keyValue;
        }

        /// <summary>
        /// RedisConnection with 2 parameter.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void RedisConnection(string key, string value)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            data.StringSet(key, value);
            data.StringGet(key);
        }
    }
}
