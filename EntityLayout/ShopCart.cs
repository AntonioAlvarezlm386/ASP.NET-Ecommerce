using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class ShopCart
    {
        public int CART_ID { get; set; }
        public Client oCLIENT { get; set; }
        public Product oPRODUCT { get; set; }
        public int ITEMS { get; set; }
    }
}
