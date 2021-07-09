using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace Demo11
{
    //class FileWriter : IDisposable
    //{
    //    public void Dispose()
    //    {
            
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //using (var fw = new FileWriter())
            //{

            //}
            //WriteData();
            ReadData();

            Console.ReadKey();

        }
        private static void ReadData()
        {
            using (var fs = new FileStream(@"C:\FIS-Global\Readme.txt", FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fs))
            {

                try
                {
                    string text = sr.ReadToEnd();
                    Console.WriteLine(text);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
            }
        }

        private static void WriteData()
        {
            using (var fs = new FileStream(@"C:\FIS-Global\Readme.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    try
                    {
                        sw.WriteLine("This is text written using c#");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Error: {0}", ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: {0}", ex.Message);
                    }
                    finally
                    {
                        sw.Close();
                        fs.Close();
                    }
                }
            }


        }
    }
}
