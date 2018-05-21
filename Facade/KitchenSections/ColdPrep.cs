using System;
using Facade.Food;
using Facade.Interfaces;

namespace Facade.KitchenSections {
    internal class ColdPrep : IKitchenSection {
        public IFoodItem PrepareDish(int appId) {
            //TODO: appCollection.Get(appId);
            Console.WriteLine($"Preparing cold dish #{appId}");
            return new GoatCheeseTrio();
        }
    }
}