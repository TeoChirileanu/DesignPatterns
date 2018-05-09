using AbstractFactory.Factories;
using AbstractFactory.Food.ConcreteFood;

namespace AbstractFactory {
    internal class AdultMenuFactory : IMenuFactory {
        public IMenu Create() {
            return new FoodMenu {
                Sandwitch = new Blt(),
                Dessert = new CremeBrulee()
            };
        }
    }
}