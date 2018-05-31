using System;
using Facade.Food;
using Facade.Interfaces;

namespace Facade.KitchenSections {
    internal class Bar : IKitchenSection {
        public IFoodItem PrepareDish(int drinkId) {
            Console.WriteLine($"Preparing drink #{drinkId}");
            return new Bier();
        }
    }
}