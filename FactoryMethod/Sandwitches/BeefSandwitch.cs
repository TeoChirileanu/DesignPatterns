using FactoryMethod.Ingredients;
using FactoryMethod.Interfaces;

namespace FactoryMethod {
    internal class BeefSandwitch : Sandwitch {
        public override string Name => "Beefy Beef Sandiwitch";

        protected override void CreateIngredients() {
            Ingredients.AddRange(new IIgredient[] {
                new Bread(),
                new Beef(),
                new Mayonnaise(),
                new Beef(),
                new Bread()
            });
        }
    }
}