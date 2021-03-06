﻿using System.Collections.Generic;
using FabioSereno.App_awsDotNetCoreEntitySortApi.Models;

namespace FabioSereno.App_awsDotNetCoreEntitySortApi.Interfaces
{
    public interface IEmployeeSortUtil
    {
        /// <summary>
        /// Default entity sort method, relies on the Employee's IComparable implementation
        /// </summary>
        /// <param name="employees">A List of Employee types to sort</param>
        /// <returns>Returns the sorted List of Employees</returns>
        List<Employee> SortBySalaryDefault(List<Employee> employees);

        /// <summary>
        /// Sorts by Employee Salary descending, relies an IComparer implementation being passed in to the Sort method
        /// </summary>
        /// <param name="employees">A List of Employee types to sort</param>
        /// <returns>Returns the sorted List of Employees</returns>
        List<Employee> SortBySalaryDesc(List<Employee> employees);

        /// <summary>
        /// Sorts by Employee Salary ascending, relies an IComparer implementation being passed in to the Sort method
        /// </summary>
        /// <param name="employees">A List of Employee types to sort</param>
        /// <returns>Returns the sorted List of Employees</returns>
        List<Employee> SortBySalaryAsc(List<Employee> employees);
    }
}
