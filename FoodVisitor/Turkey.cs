namespace FoodVisitor {
    internal class Turkey : Food {
        protected override string Name => "Turkish Turkey";

        protected internal override double AmountOfSaltUsed { get; set; } = 0.75;

        protected internal override double AmountOfPepperUsed { get; set; } = 0.55;
    }
}