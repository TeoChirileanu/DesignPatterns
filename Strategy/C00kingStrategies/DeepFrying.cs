using System;
using Strategy.Interfaces;

namespace Strategy.C00kingStrategies {
    internal class DeepFrying : ICookingStrategy {
        public void Cook(string food) {
            Console.WriteLine($"Cooking your {food} by deep frying it...");
        }
    }
}