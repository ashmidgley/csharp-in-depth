using System.Collections.Generic;

namespace App
{
    public static class ImplicitTyping
    {
        public static void Usage()
        {
            // Local variables
            Dictionary<string, List<decimal>> mappingOld = new Dictionary<string, List<decimal>>();
            var mappingNew = new Dictionary<string, List<decimal>>();

            // Arrays
            int[] arrayOld = new int[] { 1, 2, 3 };
            var arrayNew = new[] { 1, 2, 3 };
        }
    }
}
