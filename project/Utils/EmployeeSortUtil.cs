using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using FabioSereno.App_awsDotNetCoreEntitySortApi.Interfaces;
using FabioSereno.App_awsDotNetCoreEntitySortApi.Models;

namespace FabioSereno.App_awsDotNetCoreEntitySortApi.Utils
{
    public class EmployeeSortUtil : IEmployeeSortUtil
    {
        private readonly ILogger<EmployeeSortUtil> _logger;
        public EmployeeSortUtil(ILogger<EmployeeSortUtil> logger)
        {
            _logger = logger;
        }

        /// <inheritdoc/>
        public List<Employee> SortBySalaryDefault(List<Employee> employees)
        {
            _logger.LogInformation("Sort by defaut started");

            employees?.Sort();

            _logger.LogInformation("Sort by defaut finished");

            return employees ?? new List<Employee>();
        }

        /// <inheritdoc/>
        public List<Employee> SortBySalaryDesc(List<Employee> employees)
        {
            _logger.LogInformation("Sort by salary descending started");

            employees?.Sort(new Employee.SortBySalaryDesc());

            _logger.LogInformation("Sort by salary descending finished");

            return employees ?? new List<Employee>();
        }

        /// <inheritdoc/>
        public List<Employee> SortBySalaryAsc(List<Employee> employees)
        {
            _logger.LogInformation("Sort by salary ascending started");

            employees?.Sort(new Employee.SortBySalaryAsc());

            _logger.LogInformation("Sort by salary ascending finished");

            return employees ?? new List<Employee>();
        }
    }
}
