using AbstractFactory.Food;
using AbstractFactory.Food.ConcreteFood;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories {
    internal sealed class ChildrenMenuFactory : IMenuFactory {
        public IMenu CreateMenu() {
            return new FoodMenu {
                Sandwitch = new GrilledCheese(),
                Dessert = new IceCreamSundae()
            };
        }
    }
}