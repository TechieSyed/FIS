using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo111
{
    interface IVersion
    {
        void GetVersion();
    }
    interface IVersion2
    {
        void GetVersion();
    }
    class Version : IVersion, IVersion2
    {
        void IVersion.GetVersion()
        {
            Console.WriteLine("IVersion 1 GetVersion executed");
        }
        void IVersion2.GetVersion()
        {
            Console.WriteLine("IVersion 2 GetVersion executed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Version();

            //IVersion v1 = v;
            //v1.GetVersion();

            //IVersion2 v2 = v;
            //v2.GetVersion();

            IVersion v1 = v as IVersion;
            if (v1 != null)
            {
                v1.GetVersion();
            }

            if (v is IVersion2)
            {
                ((IVersion2)v).GetVersion();
            }

            Console.ReadKey();
        }
    }
}
