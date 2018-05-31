using System.Collections.Generic;
using Strategy.Interfaces;

namespace Strategy.C00kingStrategies {
    internal static class CookingStrategies {
        static CookingStrategies() {
            Strategies.Add(0, new OvenBacking());
            Strategies.Add(1, new Grilling());
            Strategies.Add(2, new DeepFrying());
        }

        internal static Dictionary<int, ICookingStrategy> Strategies { get; } =
            new Dictionary<int, ICookingStrategy>();
    }
}