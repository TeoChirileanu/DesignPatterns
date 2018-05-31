using System;
using Strategy.Interfaces;

namespace Strategy.C00kingStrategies {
    internal class OvenBacking : ICookingStrategy {
        public void Cook(string food) {
            Console.WriteLine($"Cooking your {food} by oven backing it...");
        }
    }
}