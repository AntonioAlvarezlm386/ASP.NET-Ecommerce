using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class PRODUCT
    {
        public int PRODUCT_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int BRAND_ID { get; set; }
        public int CATEGORY_ID { get; set; }
        public decimal PRICE { get; set; }
        public int STOCK { get; set; }
        public string IMG_PATH { get; set; }
        public string IMG_NAME { get; set; }
        public bool AVAILABLE { get; set; }
        public DateTime CREATED_AT { get; set; }

        public virtual BRAND BRAND { get; set; }
        public virtual CATEGORY CATEGORY { get; set; }
        public virtual ICollection<SHOPP_CART> SHOPCARTS {  get; set; }    
        public virtual ICollection<SALE_DETAIL> SALE_DETAILS { get; set; }
    }
}
