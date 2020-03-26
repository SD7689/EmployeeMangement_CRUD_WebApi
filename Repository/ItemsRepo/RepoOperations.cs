// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepoOperations.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.ReposItems
{
    using Model;
    using Repository.IRepos;
    using Repository.UserContext;
    using System.Collections.Generic;

    /// <summary>
    /// RepoOperations class implements IRepo interface.
    /// </summary>
    public class RepoOperations : IRepo
    {
        private readonly UserDbContext userDBContext;

        /// <summary>
        /// Constructor RepoOperations.
        /// </summary>
        /// <param name="userDBContext"></param>
        public RepoOperations(UserDbContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        /// <summary>
        /// AddEmployee method.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Employee AddEmployee(Employee employee)
        {
            userDBContext.Employees.Add(employee);
            userDBContext.SaveChanges();
            return employee;
        }

        /// <summary>
        /// DeleteEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee DeleteEmployee(int id)
        {
            Employee employee = userDBContext.Employees.Find(id);
            if (employee != null)
            {
                userDBContext.Employees.Remove(employee);
                userDBContext.SaveChanges();
            }
            return employee;

        }

        /// <summary>
        /// GetAllEmployees method.
        /// </summary>
        /// <returns> Employee </returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return userDBContext.Employees;
        }

        /// <summary>
        /// GetEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }

        /// <summary>
        /// UpdateEmployee method.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        public Employee UpdateEmployee(Employee employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            userDBContext.SaveChanges();
            return employeeChanges;
        }
    }
}
