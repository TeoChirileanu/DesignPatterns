using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FoodVisitor.F00d.Ingredients;
using FoodVisitor.Interfaces;

namespace FoodVisitor.F00d {
    internal class FoodBox : IVisitee {
        public FoodBox() {
            Food = new Collection<Food> {
                new Beef(),
                new Cheese(),
                new Turkey()
            };
        }

        private IEnumerable<Food> Food { get; }

        public void Accept(IVisitor visitor) {
            foreach (var food in Food)
                food.Accept(visitor);
        }

        public override string ToString() {
            var stringBuilder = new StringBuilder();
            foreach (var food in Food)
                stringBuilder.AppendLine(food.ToString());
            return stringBuilder.ToString();
        }
    }
}