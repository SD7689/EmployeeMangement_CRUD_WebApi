// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IManager.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager.ManagerInterface
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEmployeeManager
    {
        Employee GetEmployee(int id);

        IEnumerable<Employee> GetAllEmployees();
        
        Task<int> AddEmployee(Employee employee);
        
        Task<int> UpdateEmployee(Employee employeeChanges);
        
        Employee DeleteEmployee(int id);
    }
}
