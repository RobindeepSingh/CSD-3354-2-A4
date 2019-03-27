using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();

        }
        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download Complete");

        }
    }
    class Network
    {
        static public Task Download()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(3000); // Seconds
            });
        }
    }
}

