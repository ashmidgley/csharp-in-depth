namespace App
{
    public static class NullableValueTypes
    {
        // Structs are best suited for small data structures that contain primarily 
        // data that is not intended to be modified after the struct is created.
        public struct Order {
            public int CustomerId;
            public int ProductId;
            // Alternative type is Nullable<int>.
            public int? CompanyId;
        }

        public static Order GenerateOrderWithCompanyId() => new Order
        {
            CustomerId = 1,
            ProductId = 1,
            CompanyId = 1
        };

        public static Order GenerateOrderWithoutCompanyId() => new Order
        {
            CustomerId = 1,
            ProductId = 1
        };
    }
}
