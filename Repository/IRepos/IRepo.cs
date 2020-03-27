// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepo.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.IRepos
{
    using Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// interface IRepo.
    /// </summary>
    public interface IRepo
    {
        /// <summary>
        /// GetEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee GetEmployee(int id);

        /// <summary>
        /// GetAllEmployees method.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> GetAllEmployees();

        /// <summary>
        /// AddEmployee method.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<int> AddEmployee(Employee employee);

        /// <summary>
        /// UpdateEmployee method.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        Task<int> UpdateEmployee(Employee employeeChanges);

        /// <summary>
        /// DeleteEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee DeleteEmployee(int id);
    }
}
