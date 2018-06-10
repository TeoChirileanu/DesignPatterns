namespace NoNeedForFoodVisitor {
    public interface IFood {
        string Name { get; set; }

        // Amount of salt, expressed in grams
        double Salt { get; set; }
        double Pepper { get; set; }
    }
}