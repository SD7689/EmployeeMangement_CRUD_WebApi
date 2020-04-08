// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeManager.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager.ManagerImplementation
{
    using Manager.ManagerInterface;
    using Model;
    using Repository.RepositoryInterface;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// EmployeeManager implements IEmployeeManager.
    /// </summary>
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// The user IEmployeeRepository repo
        /// </summary>
        private readonly IEmployeeRepository repo;

        /// <summary>
        /// EmployeeManager Constructor
        /// </summary>
        /// <param name="repo"></param>
        public EmployeeManager(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// AddEmployee Method.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns> Add Employee data in database </returns>
        public Task<int> AddEmployee(Employee employee)
        {
            return this.repo.AddEmployee(employee);
        }

        /// <summary>
        /// DeleteEmployee Method
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Delte Employee data in database</returns>
        public Employee DeleteEmployee(int id)
        {
            return this.repo.DeleteEmployee(id);
        }

        /// <summary>
        /// GetAllEmployees Method.
        /// </summary>
        /// <returns> GetAllEmployees Employee data in database </returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repo.GetAllEmployees();
        }

        /// <summary>
        /// GetEmployee Method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> GetEmployee data in database</returns>
        public Employee GetEmployee(int id)
        {
            return this.repo.GetEmployee(id);
        }

        /// <summary>
        /// UpdateEmployee Method.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns> UpdateEmployee Employee data in database </returns>
        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            return this.repo.UpdateEmployee(employeeChanges);
        }

        /// <summary>
        /// EmployeeLogin Method.
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool EmployeeLogin(string email, string password)
        {
            return this.repo.EmployeeLogin(email,password);
        }
    }
}
