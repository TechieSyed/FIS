using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product();
            p.Id = 100;
            p.Name = "Pen";
            p.Quantity = 1000;
            p.OnOutOfStock += NotifyProcurementTeam;
            //p.OnOutOfStock(p);

            Console.WriteLine("Enter quantity");
            int qty = Convert.ToInt32(Console.ReadLine());
            p.Purchase(qty);
            Console.WriteLine("Product purchased");
            Console.ReadKey();
        }
        static void NotifyProcurementTeam(Product p)
        {
            Console.WriteLine("{0} is now out of stock", p.Name);
        }
    }
}
