using AbstractFactory.Food.AbstractFood;

namespace AbstractFactory.Food.ConcreteFood {
    internal class CremeBrulee : Dessert {
        public override string GetName() {
            return "Crème brûlée";
        }
    }
}