
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace App
{
    public static class AsynchronousCode
    {
        static HttpClient httpClient = new HttpClient();

        public static void Usage(string url)
        {
            string text = AsynchronousCode.GetContent(url).Result;
            Console.WriteLine(text);
        }

        public async static Task<string> GetContent(string url)
        {
            return await httpClient.GetStringAsync(url);
        }
    }
}