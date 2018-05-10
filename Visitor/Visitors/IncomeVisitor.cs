using System;
using Visitor.Employees;
using Visitor.Interfaces;

namespace Visitor.Visitors {
    internal class IncomeVisitor : IVisitor {
        public void Visit(IVisitee visitee) {
            Employee employee = visitee as Employee ?? throw new FormatException("Invalid Visitee");
            employee.AnnualSalary *= 1.15;
            Employees.Employees.UpdateEmployee(employee);
        }
    }
}