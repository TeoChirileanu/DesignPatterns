using AbstractFactory.Food.AbstractFood;
using AbstractFactory.Food.ConcreteFood;

namespace AbstractFactory.Factories {
    internal sealed class ChildrenMenuFactory : IMenuFactory {
        public  IMenu CreateMenu() {
            return new FoodMenu {
                Sandwitch = new GrilledCheese(),
                Dessert = new IceCreamSundae()
            };
        }
    }
}   