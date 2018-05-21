using Facade.Interfaces;

namespace Facade.Food {
    internal class LebaneseDonair : IFoodItem {
        public string Name => "Lebanese Donair";

        public int Id => 2;
    }
}