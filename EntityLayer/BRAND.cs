using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BRAND
    {
        public int BRAND_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public bool AVAILABLE { get; set; }
        public DateTime CREATED_AT { get; set; }
        public virtual ICollection<PRODUCT> PRODUCTS { get; set; }   
    }
}
