using FoodVisitor.F00d.Ingredients;

namespace FoodVisitor.Visitors {
    internal class PepperVisitor : Visitor {
        protected override void VisitInternal(Beef beef) => beef.AmountOfPepperUsed *= 1.15;

        protected override void VisitInternal(Turkey turkey) => turkey.AmountOfPepperUsed *= 1.05;

        protected override void VisitInternal(Cheese cheese) => cheese.AmountOfPepperUsed *= 1.25;
    }
}