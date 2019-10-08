namespace App
{
    public static class NullCoalescingOperator
    {
        public static int ReturnNonNullValue(int? a, int? b, int c)
        {
            return a ?? b ?? c;
        }
    }
}
