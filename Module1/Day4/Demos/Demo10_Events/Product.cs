using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Events
{
    public delegate void OutOfStock(Product p);
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public event OutOfStock OnOutOfStock;
        public void Purchase(int qty)
        {
            this.Quantity -= qty;
            if (this.Quantity <= 0)
            {
                if (OnOutOfStock != null)
                {
                    OnOutOfStock(this);
                }
            }
        }
    }
}
