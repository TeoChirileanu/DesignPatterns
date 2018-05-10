using Visitor.Interfaces;

namespace Visitor.Employees {
    internal class Employee : IVisitee {
        internal string Name { get; set; }
        internal double AnnualSalary { get; set; }
        internal int PaidTimeOffInDays { get; set; }

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }

        public override string ToString() {
            return $"Name: {Name}; Current Salary: {AnnualSalary}$; Time Off Allowed: {PaidTimeOffInDays}";
        }
    }
}