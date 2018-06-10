using System;

namespace NoNeedForFoodVisitor {
    public static class FoodExtensions {
        public static void AlterSalt(this IFood food, double percentage) {
            if (percentage <= 0 || percentage > 2) throw new Exception("Allowed percentage: 0 - 100%");
            food.Salt *= percentage;
        }

        public static void AlterPepper(this IFood food, double percentage) {
            if (percentage <= 0 || percentage > 2) throw new Exception("Allowed percentage: 0 - 100%");
            food.Pepper *= percentage;
        }
    }
}