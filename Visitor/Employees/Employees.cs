using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Employees {
    internal class Employees {
        // ReSharper disable once InconsistentNaming
        private static List<Employee> _employees { get; set; }

        internal Employees() {
            _employees= new List<Employee> {
                new Employee {
                    Name = "Sarah Sommerauer",
                    AnnualSalary = 37_800,
                    PaidTimeOffInDays = 25
                }, new Employee {
                    Name = "Markus Hoffmann",
                    AnnualSalary = 45_600,
                    PaidTimeOffInDays = 27
                }, new Employee {
                    Name = "Teodor Chirileanu",
                    AnnualSalary = double.PositiveInfinity,
                    PaidTimeOffInDays = 35
                }
            };

        }

        public static void UpdateEmployee(Employee updatedEmployee) {
            var employeeToUpdate = _employees.FirstOrDefault(e => e.Name == updatedEmployee.Name);
            if (employeeToUpdate is null) throw new ArgumentException($"No employee with name {updatedEmployee.Name} found!");
            // ReSharper disable once RedundantAssignment
            employeeToUpdate = updatedEmployee;
        }

        public  override string  ToString() {
            var employeeDetails = new StringBuilder();
            foreach (var employee in _employees)
                employeeDetails.AppendLine(employee.ToString());
            return employeeDetails.ToString();
        }

        public void Accept(IVisitor visitor) {
            foreach(var employee in _employees)
                employee.Accept(visitor);
        }
    }
}