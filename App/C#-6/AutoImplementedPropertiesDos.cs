using System.Collections.Generic;

namespace App
{
    public sealed class AutoImplementedPropertiesDos
    {
        // Read-only props
        public double XOld { get; private set; }
        public double XNew { get; }

        // Initializing autoprops
        public List<string> NamesOld { get; set; }
        public List<string> NamesNew { get; set; } = new List<string>();


        public AutoImplementedPropertiesDos(double x)
        {
            XOld = x;
            XNew = x;
            NamesOld = new List<string>();
        }
    }

    // Prior to C# 6
    public struct YuckStruct
    {
        public double X { get; private set; }

        public YuckStruct(double x) : this()
        {
            X = x;
        }
    }

    // Post C# 6
    public struct NiceStruct
    {
        public double X { get; }

        public NiceStruct(double x)
        {
            X = x;
        }
    }
}
