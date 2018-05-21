using System;
using AbstractFactory.Factories;
using AbstractFactory.Food;
using AbstractFactory.Interfaces;

namespace AbstractFactory {
    internal static class Program {
        private static void Main() {
            Console.WriteLine("What are you? (A)dult or (C)hild?");
            var answer = Console.ReadKey().KeyChar;
            IMenuFactory factory;
            switch (answer) {
                case 'C':
                    factory = new ChildrenMenuFactory();
                    break;
                case 'A':
                    factory = new AdultMenuFactory();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    return;
            }

            var menu = factory.CreateMenu() as FoodMenu ?? throw new ArgumentNullException(nameof(factory));

            Console.WriteLine("\nHere is your order:\n" +
                              $"Sandwitch: {menu.Sandwitch.GetName()}\n" +
                              $"Dessert: {menu.Dessert.GetName()}\n" +
                              "Enjoy your meal!");
        }
    }
}