using System;

namespace TemplateMethod {
    public static class Program {
        private static void Main() {
            var baguette = new Baguette();
            baguette.Make();
            Console.WriteLine();
            var wholeWheat = new WholeWheat();
            wholeWheat.Make();
            Console.WriteLine();
            var twelveGrain = new TwelveGrain();
            twelveGrain.Make();
        }
    }
}