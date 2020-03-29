// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDbContext.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository.UserContext
{
    using Microsoft.EntityFrameworkCore;
    using Model;

    /// <summary>
    /// UserDbContext class extends DbContext Class.
    /// </summary>
    public class UserDbContext : DbContext
    {
        /// <summary>
        /// Database Connection using UserDbContext.
        /// </summary>
        /// <param name="options"></param>
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// DbSet of Employee Class.
        /// </summary>
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
    }
}
