using System;
using System.IO;
using WCFDemo.Services;

namespace WCFDemo.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            JsonServiceClient client = new JsonServiceClient();

            const string path = @".\test.json";
            byte[] bytes = File.ReadAllBytes(@".\test.json");

            var result = client.UploadJson(bytes);
            Console.WriteLine(result);

            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
    }
}
