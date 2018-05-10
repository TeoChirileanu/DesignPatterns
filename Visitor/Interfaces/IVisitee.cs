namespace Visitor.Interfaces {
    internal interface IVisitee {
        void Accept(IVisitor visitor);
    }
}