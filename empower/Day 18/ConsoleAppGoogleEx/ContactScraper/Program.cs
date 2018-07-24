using System;
using System.Data.SqlClient;
using System.Net.Http;
using System.Data;

namespace ContactScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync("https://www.lemairerestaurant.com/");
            task.Wait();
            var result = task.Result;

            Console.WriteLine("Hello World!");
        }
    }
}
