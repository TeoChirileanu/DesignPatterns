using AbstractFactory.Food.AbstractFood;

namespace AbstractFactory.Food.ConcreteFood {
    internal class Blt : Sandwitch {
        public override string GetName() {
            return "	Bacon, Lettuce & Tomato";
        }
    }
}