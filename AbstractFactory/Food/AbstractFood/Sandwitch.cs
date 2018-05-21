using AbstractFactory.Interfaces;

namespace AbstractFactory.Food.AbstractFood {
    internal abstract class Sandwitch : IFood {
        public abstract string GetName();
    }
}