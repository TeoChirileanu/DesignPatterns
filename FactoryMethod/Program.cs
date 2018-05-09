using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
                    Console.WriteLine("Wrong input");
                    return;
            }

            Console.WriteLine(
                $"Here is your {sandwitch.GetName()}. JFYI, here is the list of the ingredients it's made up from: {sandwitch.GetIngredients()}");
        }
    }

    internal class TurkeySandwitch : Sandwitch {
        public override string GetName() => "Turkish Turkey Sandwitch";

        protected override void CreateIngredients() {
            throw new NotImplementedException();
        }
    }

    internal class BeefSandwitch : Sandwitch {
        public override string GetName() {
            return "Beefy Beef Sandwitch";
        }

        protected override void CreateIngredients() {
            throw new NotImplementedException();
        }
    }

    internal interface ISandwitch {
        string GetName();

        string GetIngredients();
    }

    internal abstract class Sandwitch : ISandwitch {
        private List<Ingredient> Ingredients;

        protected Sandwitch() => CreateIngredients();

        public abstract string GetName();

        public virtual string GetIngredients() {
            return string.Join(",", Ingredients);
        }

        protected abstract void CreateIngredients();
    }

    internal abstract class Ingredient { }
}