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
        public Sale oSALE { get; set; }
        public Product oPRODUCT { get; set; }
        public int ITEMS {  get; set; }
        public decimal TOTAL { get; set; }
    }
}
