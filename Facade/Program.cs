using System;

namespace Facade {
    internal static class Program {
        private static void Main() {
            var server = new Server("Marie");

            Console.WriteLine(
                $"Hello! My name is {server.Name} and I'll be your server today. What is your name?");
            var name = Console.ReadLine();
            var patron = new Patron(name);
            var orderIds = Server.GetOrder(patron);

            Server.PlaceOrder(patron, orderIds);
        }
    }
}