using System;
using FactoryMethod.Interfaces;
using FactoryMethod.Sandwitches;

namespace FactoryMethod {
    internal static class Program {
        private static void Main() {
            Console.WriteLine("What type of sandwitch would you want: (B)eef or (T)urkey?");
            var response = Console.ReadKey().KeyChar;
            ISandwitch sandwitch;
            switch (response) {
                case 'B':
                    sandwitch = new BeefSandwitch();
                    break;
                case 'T':
                    sandwitch = new TurkeySandwitch();
                    break;
                default:
                    Console.WriteLine("\nWrong input");
                    return;
            }

            Console.WriteLine(
                $"\nHere is your {sandwitch.Name}. JFYI, here is the list of the ingredients it's made up from:\n{sandwitch.Ingredients}");
        }
    }
}