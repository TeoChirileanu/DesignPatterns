using FoodVisitor.F00d.Ingredients;

namespace FoodVisitor.Visitors {
    internal class SaltVisitor : Visitor {
        protected override void VisitInternal(Beef beef) => beef.AmountOfSaltUsed *= 0.95;

        protected override void VisitInternal(Turkey turkey) => turkey.AmountOfSaltUsed *= 0.85;

        protected override void VisitInternal(Cheese cheese) => cheese.AmountOfSaltUsed *= 1.35;
    }
}