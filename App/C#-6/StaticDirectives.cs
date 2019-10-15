using System;
using static System.Math;
using static System.Net.HttpStatusCode;
using static System.String;

namespace App
{
    public static class StaticDirectives
    {
        public static void Usage() {
            Console.WriteLine(Sqrt(144));
            
            var statusCode = OK;
            switch(statusCode)
            {
                case OK:
                    break;
                case TemporaryRedirect:
                case Redirect:
                case RedirectMethod:
                    break;
                case NotFound:
                    break;
                default:
                    break;
            }

            // The import type doesnt have to be static. EG: System.String.
            string[] elements = { "a", "b" };
            Console.WriteLine(Join(", ", elements));
        }
    }
}
