using FoodVisitor.F00d.Ingredients;
using FoodVisitor.Interfaces;

namespace FoodVisitor.Visitors {
    internal abstract class Visitor : IVisitor {
        public void Visit(dynamic element) => VisitInternal(element);


        protected abstract void VisitInternal(Beef beef);

        protected abstract void VisitInternal(Turkey turkey);

        protected abstract void VisitInternal(Cheese cheese);
    }
}