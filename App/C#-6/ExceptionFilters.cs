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
                "UrRRRraaaarrr",
                "UrRRRraaaarrr mmmuururrwafsg",
                "This won't be caught."
            };
            foreach(string message in messages)
            {
                try 
                {
                    throw new Exception(message);
                }
                catch(Exception e) when (e.Message.Contains("UrRRRraaaarrr"))
                {
                    Console.WriteLine($"Caught: {e.Message}. Rope him in cowboy.");
                }
            }
        }
    }
}
