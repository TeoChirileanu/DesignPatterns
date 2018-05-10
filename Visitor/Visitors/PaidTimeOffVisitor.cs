using System;
using Visitor.Employees;
using Visitor.Interfaces;

namespace Visitor.Visitors {
    internal class PaidTimeOffVisitor : IVisitor {
        public void Visit(IVisitee visitee) {
            var employee = visitee as Employee ?? throw new FormatException("Invalid Visitee");
            employee.PaidTimeOffInDays += 5;
            Employees.Employees.UpdateEmployee(employee);
        }
    }
}