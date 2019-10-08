using System.Collections.Generic;

namespace App
{
    public static class CollectionInitializer
    {
        public static void ExampleUsage()
        {
            List<string> collectionOld = new List<string>();
            collectionOld.Add("Maggie");
            collectionOld.Add("Lisa");
            collectionOld.Add("Bart");

            var collectionNew = new List<string> { "Maggie", "Lisa", "Bart" };
        }
    }
}
