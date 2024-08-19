using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayout
{
    public class Sale
    {
        public int SALE_ID { get; set; }
        public Client oCLIENT { get; set; }
        public int ITEMS { get; set; } 
        public decimal TOTAL { get; set; }
        public string CONTACT { get; set; }
        public Locality oLOCALITY { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public string TRANS_ID { get; set; }
        public DateTime CREATED_AT { get; set; }
        public virtual Client CLIENT { get; set; }
        public virtual ICollection<SaleDetail> SALE_DETAIL { get; set; }
    }
}
