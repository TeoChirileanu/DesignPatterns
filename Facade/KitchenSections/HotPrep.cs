using System;
using Facade.Food;
using Facade.Interfaces;

namespace Facade.KitchenSections {
    internal class HotPrep : IKitchenSection {
        public IFoodItem PrepareDish(int entreeId) {
            Console.WriteLine($"Preparing hot dish #{entreeId}");
            return new LebaneseDonair();
        }
    }
}