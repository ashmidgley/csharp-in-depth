using System;

namespace App
{
    public static class AnonymousTypes
    {
        public struct Order {
            public int CustomerId;
            public int ProductId;
        }

        public static void Usage()
        {
            var player = new
            {
                Username = "Zero Cool",
                Score = 420
            };

            Console.WriteLine(player.Username.Substring(0, 4));
            Console.WriteLine(player.Score + 5);

            // Projection intializer
            var flattenedItem = new
            {
                player.Username, // Variable names are infered
                player.Score
            };

            Console.WriteLine($"Flattened item: Username = {flattenedItem.Username}, Score = {flattenedItem.Score}");
        }
    }
}
