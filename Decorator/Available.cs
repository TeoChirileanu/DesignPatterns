using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Decorator {
    public class Available : Decorator {
        private readonly ICollection<string> _customers = new Collection<string>();
        public int NumberOfDishesAvailable { private get; set; }

        public void OrderItem(string name) {
            if (NumberOfDishesAvailable > 0) {
                _customers.Add(name);
                NumberOfDishesAvailable--;
            }
            else Console.WriteLine($"Not enough ingredients for {name}'s order!");
        }

        public void DisplayDishAndWhoOrderedIt() {
            RestaurantDish.Display();
            foreach (string customer in _customers)
                Console.WriteLine($"Ordered by {customer}");
        }
    }
}