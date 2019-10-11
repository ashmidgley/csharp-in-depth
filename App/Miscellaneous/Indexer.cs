using System;
using System.Collections.Generic;

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
                if(value < 0){
                    throw new ArgumentOutOfRangeException();
                }
                Collection[index] = value;
            }
        }

        public Indexer(List<int> collection)
        {
            Collection = collection;
        }
    }
}
