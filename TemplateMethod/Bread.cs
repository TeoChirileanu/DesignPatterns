using System;

namespace TemplateMethod {
    public abstract class Bread {
        protected abstract void MixIngredients();
        protected abstract void Bake();
        protected virtual void Slice() => Console.WriteLine($"Slicing {GetType().Name}...");

        public void Make() {
            MixIngredients();
            Bake();
            Slice();
        }
    }
}