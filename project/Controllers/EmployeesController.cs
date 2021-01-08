using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FabioSereno.App_awsDotNetCoreEntitySortApi.Models;
using FabioSereno.App_awsDotNetCoreEntitySortApi.Interfaces;

namespace FabioSereno.App_awsDotNetCoreEntitySortApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeSortUtil _employeeSortUtil;

        public EmployeesController(IEmployeeSortUtil employeeSortUtil)
        {
            _employeeSortUtil = employeeSortUtil;
        }

        [HttpPost("sort/salary/desc")]
        public IList<Employee> SortBySalaryDesc([FromBody]GetRequest request)
        {
            var employees = _employeeSortUtil.SortBySalaryDesc(request?.Employees);
            return employees;
        }

        [HttpPost("sort/salary/asc")]
        public IList<Employee> SortBySalaryAsc([FromBody]GetRequest request)
        {
            var employees = _employeeSortUtil.SortBySalaryAsc(request?.Employees);
            return employees;
        }
    }
}