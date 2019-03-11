// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// creating delegate
    /// </summary>
    /// <param name="employee">The employee.</param>
    /// <returns>bool value</returns>
    public delegate bool IsPromotable(Employee employee);

    /// <summary>
    /// employee class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public int Salary { get; set; }

        /// <summary>
        /// Gets or sets the experience.
        /// </summary>
        /// <value>
        /// The experience.
        /// </value>
        public int Experience { get; set; }

        /// <summary>
        /// Promotes the employee.
        /// </summary>
        /// <param name="employeeList">The employee list.</param>
        /// <param name="isEligibleToPromote">The is eligible to promote.</param>
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligibleToPromote)
        {
            ////to traverse emloyee List object
            foreach (Employee employee in employeeList)
            {
                if (isEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " " + "promoted");
                }
            }
        }
    }
}
