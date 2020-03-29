// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeManager.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager.ManagerInterface
{
    using Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// IEmployeeManager Interface. 
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// GetEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> It returns if execution is successful or not </returns>
        Employee GetEmployee(int id);

        /// <summary>
        /// GetAllEmployees Method.
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
        /// UpdateEmployee Method.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns> It returns if execution is successful or not </returns>
        Task<int> UpdateEmployee(Employee employeeChanges);

        /// <summary>
        /// DeleteEmployee Method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> It returns if execution is successful or not </returns>
        Employee DeleteEmployee(int id);
    }
}
