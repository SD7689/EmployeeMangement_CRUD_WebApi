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
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
    }
}
