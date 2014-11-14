using System;
using System.Net.Http;
using Api;

namespace SelfHost
{
    class Program
    {
        static void Main()
        {
            const string baseAddress = "http://localhost:9001/";

            using (Microsoft.Owin.Hosting.WebApp.Start<Startup>(baseAddress))
            {
                var client = new HttpClient();
                var response = client.GetAsync(baseAddress + "api/values").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            Console.ReadLine();
        }
    }
}
