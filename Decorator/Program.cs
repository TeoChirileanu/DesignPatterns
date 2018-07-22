namespace Decorator {
    public static class Program {
        private static void Main() {
            var salad = new Salad {
                Greens = "Lettuce",
                Cheese = "Parmesan",
                Dressing = "Caesar"
            };
            salad.Display();
            var pasta = new Pasta {
                PastaType = "Daily Pasta",
                Sauce = "Alfredo"
            };
            pasta.Display();

            var saladAvailable =
                new Available {RestaurantDish = salad, NumberOfDishesAvailable = 3};
            var pastaAvailable =
                new Available {RestaurantDish = pasta, NumberOfDishesAvailable = 4};

            saladAvailable.OrderItem("Mike");
            saladAvailable.OrderItem("John");
            saladAvailable.OrderItem("Chris");

            pastaAvailable.OrderItem("Mariana");
            pastaAvailable.OrderItem("Jake");
            pastaAvailable.OrderItem("Constantin");
            pastaAvailable.OrderItem("Gabriela");
            pastaAvailable.OrderItem("Gunther");

            saladAvailable.DisplayDishAndWhoOrderedIt();
            pastaAvailable.DisplayDishAndWhoOrderedIt();
        }
    }
}