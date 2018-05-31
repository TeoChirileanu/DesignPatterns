namespace FoodVisitor.Interfaces {
    internal interface IVisitee {
        void Accept(IVisitor visitor);
    }
}