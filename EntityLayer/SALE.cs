using System;
using System.Collections.Generic;

namespace EntityLayer
{
    public class SALE
    {
        public int SALE_ID { get; set; }
        public int CLIENT_ID { get; set; }
        public int ITEMS { get; set; }
        public decimal TOTAL { get; set; }
        public string CONTACT { get; set; }
        public string LOCALITY_ID { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public string TRANS_ID { get; set; }
        public DateTime CREATED_AT { get; set; }
        public virtual CLIENT CLIENT { get; set; }
        public virtual LOCALITY LOCALITY { get; set; }
        public virtual ICollection<SALE_DETAIL> SALE_DETAILS { get; set; }
    }
}
