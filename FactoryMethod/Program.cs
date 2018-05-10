using System;
using System.Collections.Generic;
using System.Linq;

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
                $"\nHere is your {sandwitch.Name}. JFYI, here is the list of the ingredients it's made up from:\n{sandwitch.Ingredients}");
        }
    }

    internal class TurkeySandwitch : Sandwitch {
        public override string Name => "Turkish Turkey Sandwitch";

        protected override void CreateIngredients() {
            Ingredients.AddRange(new Ingredient[] {
                new Bread(),
                new Turkey(),
                new Cheese(),
                new Turkey(),
                new Bread()
            });
        }
    }

    internal class BeefSandwitch : Sandwitch {
        public override string Name => "Beefy Beef Sandiwitch";

        protected override void CreateIngredients() {
            Ingredients.AddRange(new Ingredient[] {
                new Bread(),
                new Beef(),
                new Mayonnaise(),
                new Beef(),
                new Bread()
            });
        }
    }

    internal interface ISandwitch {
        string Name { get; }

        string Ingredients { get; }
    }

    internal abstract class Sandwitch : ISandwitch {
        protected Sandwitch() {
            CreateIngredients();
        }

        public abstract string Name { get; }

        string ISandwitch.Ingredients => string.Join("\n", Ingredients.Select(ingredient => ingredient.Name));

        protected List<Ingredient> Ingredients { get; } = new List<Ingredient>();

        protected abstract void CreateIngredients();
    }

    internal abstract class Ingredient {
        public abstract string Name { get; }
    }

    internal class Bread : Ingredient {
        public override string Name => "One piece of bread";
    }

    internal class Beef : Ingredient {
        public override string Name => "Roasted Beef";
    }

    internal class Turkey : Ingredient {
        public override string Name => "Roasted Turkey";
    }

    internal class Mayonnaise : Ingredient {
        public override string Name => "Juicy Mayonnaise";
    }

    internal class Cheese : Ingredient {
        public override string Name => "Cheesy Cheese";
    }
}