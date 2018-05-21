using AbstractFactory.Interfaces;

namespace AbstractFactory.Food {
    internal class FoodMenu : IMenu {
        public IFood Sandwitch { get; set; }
        public IFood Dessert { get; set; }

        public string GetName() {
            return "Food Menu";
        }
    }
}