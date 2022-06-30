using System;

namespace CustomWebServer // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WebServer server = new WebServer(65400);
            server.Start();

            
        }
    }
}