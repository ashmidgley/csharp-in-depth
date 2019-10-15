using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class Indexer
    {
        public List<int> Collection { get; set; }
        public int this[int index]
        {
            get => Collection[index];
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Collection[index] = value;
            }
        }

        public Indexer(List<int> collection)
        {
            Collection = collection;
        }

        public override string ToString()
        {
            if(Collection.Count == 0)
            {
                return $"Collection is empty.";
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach(int value in Collection)
            {
                stringBuilder.Append(value);
            }
            return stringBuilder.ToString();
        }
    }
}
