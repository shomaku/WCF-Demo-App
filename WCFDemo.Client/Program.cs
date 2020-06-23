using System;
using System.IO;
using WCFDemo.Client.Services;

namespace WCFDemo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new JsonServiceClient();

            const string path = @".\test.json";
            byte[] bytes = File.ReadAllBytes(@".\test.json");

            var result = client.UploadJson(bytes);
            Console.WriteLine(result);

            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
    }
}
