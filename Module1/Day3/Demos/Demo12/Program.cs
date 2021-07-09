using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace Demo12
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteData();
            ReadData();
            Console.ReadKey();
        }
        private static void WriteData()
        {
            using (var fs = new FileStream(@"C:\FIS-Global\ReadMe.dat", FileMode.Create, FileAccess.Write))
            using (var br = new BinaryWriter(fs))
            {
                try
                {
                    string name = "jojo";
                    int age = 23;
                    bool isfisemployee = false;

                    br.Write(name);
                    br.Write(age);
                    br.Write(isfisemployee);
                    Console.WriteLine("Data written to file");
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
                    br.Close();
                    fs.Close();
                }
            }
        }

        private static void ReadData()
        {
            using (var fs = new FileStream(@"C:\FIS-Global\ReadMe.dat", FileMode.Open, FileAccess.Read))
            using (var br = new BinaryReader(fs))
            {
                try
                {
                    string name = br.ReadString();
                    int age = br.ReadInt32();
                    bool isfisemployee = br.ReadBoolean();


                    Console.WriteLine("Name={0}, Age={1}, Is Fis employee = {2}", name, age, isfisemployee);
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
                    br.Close();
                    fs.Close();
                }
            }
        }
    }
}
