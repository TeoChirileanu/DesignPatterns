namespace FoodVisitor.F00d.Ingredients {
    internal class Beef : Food {
        protected override string Name => "Beefy Beef";

        protected internal override double AmountOfSaltUsed { get; set; } = 0.90;

        protected internal override double AmountOfPepperUsed { get; set; } = 1.2;
    }
}