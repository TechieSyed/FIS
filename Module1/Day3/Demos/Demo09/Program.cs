using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace Demo09
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fi = new FileInfo(@"C:\ITR.zip");
                Console.WriteLine("File is present : {0}", fi.Exists);
                Console.WriteLine("Created On : {0}", fi.CreationTime);
                Console.WriteLine("Size in Bytes : {0}", fi.Length);
                Console.WriteLine("Full name : {0}", fi.FullName);
                Console.WriteLine("File extension : {0}", fi.Extension);
                Console.WriteLine("Directory : {0}", fi.DirectoryName);

                if (fi.Exists)
                {
                    fi.CopyTo(@"C:\ITR1.zip");
                }
                else
                {
                    fi.Create();
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            
           

            Console.ReadKey();
        }
    }
}
