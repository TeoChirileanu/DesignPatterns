using System;
using Strategy.Context;

namespace Strategy {
    internal class Program {
        private static void Main() {
            var cookingMethod = new CookingMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookingMethod.FindAppropriateCookingMethod(food);
            cookingMethod.Cook();
        }
    }
}