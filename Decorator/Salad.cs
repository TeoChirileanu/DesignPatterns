using System;

namespace Decorator {
    public class Salad : IRestaurantDish {
        public string Greens { private get; set; }
        public string Cheese { private get; set; }
        public string Dressing { private get; set; }

        public void Display() {
            Console.WriteLine($"This gorgeous {GetType().Name} contains the following:\n" +
                              $"Greens: {Greens}\nCheese: {Cheese}\nDressing: {Dressing}\n");
        }
    }
}