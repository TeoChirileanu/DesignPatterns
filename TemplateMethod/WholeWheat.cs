using System;

namespace TemplateMethod {
    public class WholeWheat: Bread {
        protected override void MixIngredients() => Console.WriteLine("Preparing the ingredients for a fancy whole wheat bread...");
        protected override void Bake() => Console.WriteLine("Baking this beauty for 27.5 minutes...");
    }
}