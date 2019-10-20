namespace App
{
    public class PrivateProtectedAccess
    {
        private protected int Id;
        private protected string Name { get; set; }

        private protected void Usage() {}
    }
}
