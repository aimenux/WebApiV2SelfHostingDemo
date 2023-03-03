using System;
using Microsoft.Owin.Hosting;

namespace App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            const string url = "http://localhost:5000/";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($"Application is running on host {url}");
                Console.WriteLine("Press any key to terminate...");
                Console.ReadLine();
            }
        }
    }
}