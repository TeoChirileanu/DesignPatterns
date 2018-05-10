using System;
using Visitor.Visitors;

namespace Visitor {
    internal static class Program {
        private static void Main() {
            var employees = new Employees.Employees();
            Console.WriteLine(employees);
            employees.Accept(new IncomeVisitor());
            employees.Accept(new PaidTimeOffVisitor());
            Console.WriteLine(employees);
        }
    }
}