using System;

namespace App
{
    public static class AnonymousTypes
    {
        public struct Order {
            public int CustomerId;
            public int ProductId;
        }

        public static void ExampleUsage()
        {
            var player = new
            {
                Username = "Zero Cool",
                Score = 420
            };

            Console.WriteLine($"Username = {player.Username}, score = {player.Score}.");

            // Projection intializer
            var order = new Order 
            {
                CustomerId = 1,
                ProductId = 1
            };

            var flattenedItem = new
            {
                order.CustomerId, // Variable names are infered
                order.ProductId
            };

            Console.WriteLine($"Flattened item: CustomerId = {flattenedItem.CustomerId}, ProductId = {flattenedItem.ProductId}");
        }
    }
}
