using AbstractFactory.Food;
using AbstractFactory.Food.ConcreteFood;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories {
    internal class AdultMenuFactory : IMenuFactory {
        public IMenu CreateMenu() {
            return new FoodMenu {
                Sandwitch = new Blt(),
                Dessert = new CremeBrulee()
            };
        }
    }
}