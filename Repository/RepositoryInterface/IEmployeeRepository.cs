// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeRepository.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository.RepositoryInterface
{
    using Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// interface IRepo.
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// GetEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> It returns if execution is successful or not </returns>
        Employee GetEmployee(int id);

        /// <summary>
        /// GetAllEmployees method.
        /// </summary>
        /// <returns> It returns if execution is successful or not </returns>
        IEnumerable<Employee> GetAllEmployees();

        /// <summary>
        /// AddEmployee method.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns> It returns if execution is successful or not </returns>
        Task<int> AddEmployee(Employee employee);

        /// <summary>
        /// UpdateEmployee method.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns> It returns if execution is successful or not </returns>
        Task<int> UpdateEmployee(Employee employeeChanges);

        /// <summary>
        /// DeleteEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> It returns if execution is successful or not </returns>
        Employee DeleteEmployee(int id);

        /// <summary>
        /// EmployeeLogin Method.
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool EmployeeLogin(string email, string password);
    }
}
