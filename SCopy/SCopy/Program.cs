using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2)
            {
                Console.WriteLine("Need two arguments:");
                Console.WriteLine("SCopy.exe source_folder target_folder");
                return;
            }

            string source_dir = args[0];
            string target_dir = args[1];
            Console.WriteLine(source_dir + " to " + target_dir);

            if (!Directory.Exists(source_dir))
            {
                Console.WriteLine("Source directory is not exist");
                return;
            }

            if (!Directory.Exists(target_dir))
            {
                Directory.CreateDirectory(target_dir);
            }

            Console.ReadKey();
        }
    }
}
