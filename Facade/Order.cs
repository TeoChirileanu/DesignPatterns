using Facade.Interfaces;

namespace Facade {
    internal class Order {
        public IFoodItem Appetizer { private get; set; }

        public IFoodItem Entree { private get; set; }

        public IFoodItem Drink { private get; set; }

        public override string ToString() {
            return $"\n{Appetizer.Name}\n{Entree.Name}\n{Drink.Name}\n";
        }
    }
}