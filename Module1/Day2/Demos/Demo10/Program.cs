using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Demo10
{
    interface I2
    {
        void M1();
    }
    interface I1 : I2
    {
        //string name;
        string P1 { get; }
        void M2();
        void M3();
    }

    class A1 : I2
    {
        public void M1()
        {
            
        }
    }


    



    class A2 : I1
    {
        public string P1 { get { return "P1 executed"; } }

        public void M1()
        {
            
        }

        public void M2()
        {
           
        }

        public void M3()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //I1 i = new I1();
            //I2 i2 = new I2();

            A2 a2 = new A2();
            Console.WriteLine(a2.P1);
            Console.ReadKey();
        }
    }
}
