using System;
using System.Net;

namespace App
{
    // Catching up with VB lol.
    public static class ExceptionFilters
    {
        public static void Usage()
        {
            try
            {
                // ...
            } catch (WebException e)
            {
                if(e.Status != WebExceptionStatus.ConnectFailure)
                {
                    throw;
                }
                // Handles connection failure.
            }

            
            try 
            {
                // ...
            } 
            catch(WebException e) when(e.Status == WebExceptionStatus.ConnectFailure)
            {
                // Handles connection failure.
            } 
            catch(WebException e) when(e.Status == WebExceptionStatus.NameResolutionFailure)
            {
                // Handles name resolution failure.
            }
            #pragma warning disable CS0168
            catch(WebException e)
            {
                // Handles Web Exceptions other than the ones specified above.
            }
            #pragma warning restore CS0168
            
            string[] messages = 
            {
                "This won't be caught by filter",
                "Honey came in and she caught me red-handed creeping with the girl next door",
                "This won't be caught by filter either"
            };

            foreach(string message in messages)
            {
                try 
                {
                    throw new Exception(message);
                }
                catch(Exception e) 
                    when (e.Message.Contains("creeping with the girl next door"))
                {
                    Console.WriteLine("It wasn't me.");
                }
                #pragma warning disable CS0168
                catch(Exception e)
                {
                    Console.WriteLine($"Caught in default block.");
                }
                #pragma warning restore CS016
            }
        }
    }
}
