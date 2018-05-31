using System;
using Strategy.C00kingStrategies;
using Strategy.Interfaces;

namespace Strategy.Context {
    internal class CookingMethod {
        private ICookingStrategy CookingStrategy { get; set; }

        private string FoodToPrepare { get; set; }

        public void Cook() => CookingStrategy.Cook(FoodToPrepare);

        public void FindAppropriateCookingMethod(string food) {
            FoodToPrepare = food;

            // determine the right way to cook the desired food by examining it's "maginal number"
            var magicNumber = food.Length * food.Length * Math.E - food.Length * Math.PI;
            if (magicNumber < 100) CookingStrategy = CookingStrategies.Strategies[0];
            else if (magicNumber < 200) CookingStrategy = CookingStrategies.Strategies[1];
            else CookingStrategy = CookingStrategies.Strategies[2];

            Console.WriteLine("We found the best way to cook your food!");
        }
    }
}