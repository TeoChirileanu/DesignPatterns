using FactoryMethod.Ingredients;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Sandwitches {
    internal class TurkeySandwitch : Sandwitch {
        public override string Name => "Turkish Turkey Sandwitch";

        protected override void CreateIngredients() {
            Ingredients.AddRange(new IIgredient[] {
                new Bread(),
                new Turkey(),
                new Cheese(),
                new Turkey(),
                new Bread()
            });
        }
    }
}