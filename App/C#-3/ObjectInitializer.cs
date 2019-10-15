namespace App
{
    public static class ObjectInitializer
    {
        public struct Order {
            public int CustomerId;
            public int ProductId;
        }

        public static void Usage()
        {
            Order orderOld = new Order();
            orderOld.CustomerId = 1;
            orderOld.ProductId = 1;

            var orderNew = new Order 
            {
                CustomerId = 1,
                ProductId = 1
            };
        }
    }
}
