using FoodVisitor.Interfaces;

namespace FoodVisitor.F00d {
    internal abstract class Food : IVisitee {
        protected abstract string Name { get; }
        protected internal abstract double AmountOfSaltUsed { get; set; }
        protected internal abstract double AmountOfPepperUsed { get; set; }

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }

        public override string ToString() {
            return $"Name: {Name}; Salt: {AmountOfSaltUsed}; Pepper: {AmountOfPepperUsed}";
        }
    }
}