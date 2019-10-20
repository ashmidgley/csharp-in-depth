namespace App
{
    public static class OutVariables
    {
        public static int? Usage(string text)
        {
            // Previously 2 seperate statements: int value; then below.
            return int.TryParse(text, out int value) ? value : (int?) null;
        }
    }
}
