using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace Demo10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var di = new DirectoryInfo(@"C:\FIS");
                Console.WriteLine("Directory present : {0}", di.Exists);
                Console.WriteLine("Directory Name : {0}", di.Name);
                Console.WriteLine("Directory Full Path : {0}", di.FullName);
                Console.WriteLine("Directory Created on : {0}", di.CreationTime);
                Console.WriteLine("Files present in {0} ", di.Name);
                foreach(var fi in di.GetFiles())
                {
                    Console.WriteLine(fi.Name);
                }

                var di1 = new DirectoryInfo(@"C:\FIS-Global");
                if (di1.Exists == false)
                {
                    di1.Create();
                    di1.CreateSubdirectory("Batch7");
                    foreach(var dir in di1.GetDirectories())
                    {
                        Console.WriteLine(dir.Name);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
