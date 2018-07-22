using System;

namespace TemplateMethod {
    public class TwelveGrain: Bread {
        protected override void MixIngredients() => Console.WriteLine("Getting the ingredients for this healthy bready bread...");

        protected override void Bake() {
            Console.WriteLine("Baking this way too healthy bread for 1337 minutes...");
        }

        protected override void Slice() => Console.WriteLine("Healthy breads cannot be sliced!");
    }
}