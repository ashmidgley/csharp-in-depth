namespace App
{
    public static class NonTrailingNamedArguments
    {
        static void Method(int x, int y, int z) {}

        public static void Usage()
        {
            Method(5, z: 2, y: 10);
            Method(1, y: 10, 2);
        }
    }
}
