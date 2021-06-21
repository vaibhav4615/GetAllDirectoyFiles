using System;
using System.IO;
using System.Threading.Tasks;

namespace GetAllDirectoyFiles
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter Folder Path: ");
            string path = Console.ReadLine();
            string[] allFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            await PrintAllFiles(allFiles);
        }


        public static async Task PrintAllFiles(string[] files)
        {
            Parallel.ForEach(files, p =>
            {
                 Console.WriteLine(p);
            });
            await Task.CompletedTask;
        }
    }
}
