namespace App
{
    // Partial types allow single class, struct, interface to be declared across multiple parts/source files.
    // The various parts are combined by the compiler and act as if they were all declared together.
    partial class PartialTypes
    {
        public static void ExampleUsage()
        {
            MethodInOtherClass();
        }
    }
}
