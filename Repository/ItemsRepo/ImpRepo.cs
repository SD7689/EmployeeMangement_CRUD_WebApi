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
    using System.Threading.Tasks;

    /// <summary>
    /// RepoOperations class implements IRepo interface.
    /// </summary>
    public class ImpRepo : IRepo
    {
        private readonly UserDbContext userDBContext;

        /// <summary>
        /// Constructor RepoOperations.
        /// </summary>
        /// <param name="userDBContext"></param>
        public ImpRepo(UserDbContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        /// <summary>
        /// AddEmployee method. 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Task<int> AddEmployee(Employee employee)
        {
            userDBContext.Employees.Add(employee);
            var result = userDBContext.SaveChangesAsync();
            return result;
        }

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

        public IEnumerable<Employee> GetAllEmployees()
        {
            return userDBContext.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }

        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDBContext.SaveChangesAsync();
            return result;
        }
    }
}
