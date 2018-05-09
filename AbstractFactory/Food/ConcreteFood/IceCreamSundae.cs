using AbstractFactory.Food.AbstractFood;

namespace AbstractFactory.Food.ConcreteFood {
    internal class IceCreamSundae : Dessert {
        public override string GetName() {
            return "Ice Cream Sundae";
        }
    }
}