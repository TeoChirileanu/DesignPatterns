using AbstractFactory.Food.AbstractFood;

namespace AbstractFactory.Food.ConcreteFood {
    internal class GrilledCheese : Sandwitch {
        public override string GetName() {
            return "Cheesy Grilled Cheese";
        }
    }
}