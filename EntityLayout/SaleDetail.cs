using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class SaleDetail
    {
        public int DETAIL_ID { get; set; }
        public int SALE_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public int ITEMS {  get; set; }
        public decimal TOTAL { get; set; }
        public virtual Product PRODUCT { get; set; }
        public virtual Sale SALE { get; set; }
    }
}
