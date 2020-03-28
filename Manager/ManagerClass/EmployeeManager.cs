// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImpManager.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager.ManagerImplementation
{
    using Manager.ManagerInterface;
    using Model;
    using Repository.RepositoryInterface;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository repo;

        public EmployeeManager(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        public Task<int> AddEmployee(Employee employee)
        {
            return this.repo.AddEmployee(employee);
        }

        public Employee DeleteEmployee(int id)
        {
            return this.repo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repo.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return this.repo.GetEmployee(id);
        }


        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            return this.repo.UpdateEmployee(employeeChanges);
        }
    }
}
