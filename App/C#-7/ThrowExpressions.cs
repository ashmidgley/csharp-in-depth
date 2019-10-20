using System;

namespace App
{
    public static class ThrowExpressions
    {
        public static void Usage()
        {
            bool value = true;
            var name = value ? "Ash" : throw new ArgumentNullException();
        }

        // Expression bodied method woooo.
        public static void UnimplementedMethod() => throw new NotImplementedException();   
    }
}
