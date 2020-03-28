// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepoOperations.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.RepositoryClass
{
    using Repository.RepositoryInterface;
    using Repository.UserContext;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// RepoOperations class implements IRepo interface.
    /// </summary>C:\Users\Shiv\Desktop\EmployeeMangementCurdApi_WebApi\Repository\IRepos\IEmployeeRepository.cs
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly UserDbContext userDBContext;

        /// <summary>
        /// Constructor RepoOperations.
        /// </summary>
        /// <param name="userDBContext"></param>
        public EmployeeRepository(UserDbContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        /// <summary>
        /// AddEmployee method. 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Task<int> AddEmployee(Model.Employee employee)
        {
            userDBContext.Employees.Add(employee);
            var result = userDBContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// DeleteEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Employee DeleteEmployee(int id)
        {
            Model.Employee employee = userDBContext.Employees.Find(id);
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
        /// <returns></returns>
        public IEnumerable<Model.Employee> GetAllEmployees()
        {
            return userDBContext.Employees;
        }

        /// <summary>
        /// GetEmployee method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Employee GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }

        /// <summary>
        /// UpdateEmployee method.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(Model.Employee employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDBContext.SaveChangesAsync();
            return result;
        }
    }
}

