namespace AbstractFactory {
    internal class FoodMenu : IMenu{
        public IFood Sandwitch { get; set; }
        public IFood Dessert { get; set; }

        public string GetName() => "Food Menu";
    }
}