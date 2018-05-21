using System;
using Facade.Interfaces;
using Facade.KitchenSections;

namespace Facade {
    internal class Server {
        private static IKitchenSection _coldPrep;

        private static IKitchenSection _hotPrep;

        private static IKitchenSection _bar;

        public readonly string Name;

        public Server(string name) {
            Name = name;
            _coldPrep = new ColdPrep();
            _hotPrep = new HotPrep();
            _bar = new Bar();
        }


        public static void PlaceOrder(Patron patron, OrderIds ids) {
            var order = new Order {
                Appetizer = _coldPrep.PrepareDish(ids.AppetizerId),
                Entree = _hotPrep.PrepareDish(ids.EntreeId),
                Drink = _bar.PrepareDish(ids.DrinkId)
            };

            Console.WriteLine($"Patron {patron.Name} placed the following order: {order}");
        }

        public static OrderIds GetOrder(Patron patron) {
            Console.WriteLine($"Hello, {patron.Name}, what appetizer would you like? (1-10)");
            var appId = int.Parse(Console.ReadLine());
            Console.WriteLine("Now choose your entree (1-10):");
            var entreeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Finally, your drink, Sir (1-15):");
            var drinkId = int.Parse(Console.ReadLine());
            return new OrderIds {
                AppetizerId = appId,
                EntreeId = entreeId,
                DrinkId = drinkId
            };
        }
    }
}