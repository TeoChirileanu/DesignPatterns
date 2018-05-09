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
                $"\nHere is your {sandwitch.GetName()}. JFYI, here is the list of the ingredients it's made up from:\n{sandwitch.GetIngredients()}");
        }
    }

    internal class TurkeySandwitch : Sandwitch {
        public override string GetName() {
            return "Turkish Turkey Sandwitch";
        }

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
        public override string GetName() {
            return "Beefy Beef Sandwitch";
        }

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
        string GetName();

        string GetIngredients();
    }

    internal abstract class Sandwitch : ISandwitch {
        protected Sandwitch() {
            CreateIngredients();
        }

        protected List<Ingredient> Ingredients { get; } = new List<Ingredient>();

        public abstract string GetName();

        public virtual string GetIngredients() {
            return string.Join("\n", Ingredients.Select(ingredient => ingredient.Name));
        }

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