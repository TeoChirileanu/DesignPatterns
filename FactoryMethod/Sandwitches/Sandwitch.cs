using System.Collections.Generic;
using System.Linq;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Sandwitches {
    internal abstract class Sandwitch : ISandwitch {
        protected Sandwitch() {
            CreateIngredients();
        }

        protected List<IIgredient> Ingredients { get; } = new List<IIgredient>();

        public abstract string Name { get; }

        string ISandwitch.Ingredients => string.Join("\n", Ingredients.Select(ingredient => ingredient.Name));

        protected abstract void CreateIngredients();
    }
}