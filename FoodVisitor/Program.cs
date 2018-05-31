using System;
using FoodVisitor.F00d;
using FoodVisitor.Interfaces;
using FoodVisitor.Visitors;

namespace FoodVisitor {
    internal static class Program {
        private static void BeforeBeingVisited(IVisitee visitee) => Console.WriteLine(visitee);

        private static void AfterBeingVisited(IVisitee visitee) => Console.WriteLine(visitee);

        private static void Main() {
            IVisitee foodBox = new FoodBox();
            BeforeBeingVisited(foodBox);
            foodBox.Accept(new SaltVisitor());
            foodBox.Accept(new PepperVisitor());
            AfterBeingVisited(foodBox);
        }
    }
}