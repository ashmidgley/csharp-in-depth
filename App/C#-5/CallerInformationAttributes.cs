using System.Runtime.CompilerServices;

namespace App
{
    public static class CallerInformationAttributes
    {
        public static (string file, int line, string member) Usage(
            [CallerFilePath] string file = null,
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = null)
        {
            return (file, line, member); 
        }
    }
}
