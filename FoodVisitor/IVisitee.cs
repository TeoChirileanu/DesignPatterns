namespace FoodVisitor {
    internal interface IVisitee {
        void Accept(IVisitor visitor);
    }
}