using System;

namespace TemplateMethod {
    public class Baguette : Bread {
        protected override void MixIngredients() => Console.WriteLine("Preparing the ingredients for a delicious french baguette...");

        protected override void Bake() => Console.WriteLine("Baking this delicious baguette for 35 minutes...");
    }
}