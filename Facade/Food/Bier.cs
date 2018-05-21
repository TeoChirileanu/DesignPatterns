using Facade.Interfaces;

namespace Facade.Food {
    internal class Bier : IFoodItem {
        public string Name => "Refreshing Bier";

        public int Id => 3;
    }
}