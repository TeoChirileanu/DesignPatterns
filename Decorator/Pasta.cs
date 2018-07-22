using System;

namespace Decorator {
    public class Pasta : IRestaurantDish {
        public string PastaType { private get; set; }
        public string Sauce { private get; set; }

        public void Display() {
            Console.WriteLine($"This delicious {GetType().Name} contains:\n" +
                              $"{PastaType} with {Sauce}\n");
        }
    }
}