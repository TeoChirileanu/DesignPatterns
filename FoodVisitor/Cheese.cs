namespace FoodVisitor {
    internal class Cheese : Food {
        protected override string Name => "Cheesy Cheese";

        protected internal override double AmountOfSaltUsed { get; set; } = 0.66;

        protected internal override double AmountOfPepperUsed { get; set; } = 0.80;
    }
}