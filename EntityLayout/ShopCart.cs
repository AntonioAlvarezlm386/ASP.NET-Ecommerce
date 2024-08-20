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
        public int CLIENT_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public int ITEMS { get; set; }
        public virtual Client CLIENT { get; set; }
        public virtual Product PRODUCT { get; set; }
    }
}
