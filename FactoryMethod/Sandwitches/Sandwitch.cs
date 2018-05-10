using System.Collections.Generic;
using System.Linq;
using FactoryMethod.Interfaces;

namespace FactoryMethod {
    internal abstract class Sandwitch : ISandwitch {
        protected Sandwitch() {
            CreateIngredients();
        }

        public abstract string Name { get; }

        string ISandwitch.Ingredients => string.Join("\n", Ingredients.Select(ingredient => ingredient.Name));

        protected List<IIgredient> Ingredients { get; } = new List<IIgredient>();

        protected abstract void CreateIngredients();
    }


}