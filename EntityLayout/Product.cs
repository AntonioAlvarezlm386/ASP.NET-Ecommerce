using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class Product
    {
        public int PRODUCT_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Brand oBRAND { get; set; }
        public Category oCATEGORY { get; set; }
        public decimal PRICE { get; set; }
        public int STOCK { get; set; }
        public string IMG_PATH { get; set; }
        public string IMG_NAME { get; set; }
        public bool AVAILABLE { get; set; }
        public DateTime CREATED_AT { get; set; }

    }
}
