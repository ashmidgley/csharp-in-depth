using System.Collections.Generic;
using System.Linq;

namespace App
{
    public static class NullConditionalOperator
    {
        public static void Usage()
        {
            var allCustomers = GetCustomers();
            
            var faxCustomersOld = allCustomers
                .Where(c => c.Profile != null 
                && c.Profile.ShippingAddress != null 
                && c.Profile.ShippingAddress.Town == "Halifax");
            
            // Simple and safe property dereferencing. Breaks early if any of the values are null.
            var faxCustomersNew = allCustomers
                .Where(c => c.Profile?.ShippingAddress?.Town == "Halifax");

            // Null conditional operator with indexers
            int[] array = null;
            int? firstElement = array?[0];
        }

        public static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Profile = new Profile
                    {
                        ShippingAddress = new ShippingAddress
                        {
                            Town = "Reading"
                        }
                    }
                },
                new Customer
                {
                    Profile = new Profile
                    {
                        ShippingAddress = new ShippingAddress
                        {
                            Town = "Halifax"
                        }
                    }
                },
            };
        }
    }

    public class Customer
    {
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public ShippingAddress ShippingAddress { get; set; }
    }

    public class ShippingAddress
    {
        public string Town { get; set; }
    }
}
